using AutoMapper;
using RDOS.BaseLine.Jobs;
using RDOS.BaseLine.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers.Services.Repository;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;
using Sys.Common.Helper;
using RDOS.BaseLine.Services.Interface;
using SysAdmin.Models.StaticValue;
using RestSharp;
using RDOS.BaseLine.Models.Result;
using static RDOS.BaseLine.Constants.Constants;
using static Quartz.MisfireInstruction;

namespace RDOS.BaseLine.Service
{
    public class PhattvBLProcessService : IPhattvBLProcessService
    {
        private readonly ILogger<PhattvBLProcessService> _logger;
        private readonly IBaseRepository<BlBlsettingInformation> _blSettingInfoRepo;
        private readonly IBaseRepository<BlBlsettingProcess> _blSettingProcessRepo;
        private readonly IBaseRepository<BlBlsettingTransactionStatus> _blSettingTransactionStatusRepo;
        private readonly IBaseRepository<BlBlsettingProcessPending> _blSettingProcessPendingRepo;
        private readonly IBaseRepository<BlBlsettingEmail> _blSettingEmailRepo;
        private readonly IBaseRepository<BlBlprocess> _blProcessRepo;
        private readonly IMapper _mapper;

        private readonly IBaselineSettingService _settingService;
        private readonly ISchedulerFactory _schedulerFactory;
        public IScheduler Scheduler { get; set; }
        public readonly IClientService _clientService;
        private readonly IBaseRepository<SaleCalendarHoliday> _holidayRepo;
        private readonly IBaseRepository<SaleCalendar> _salesCalendarRepo;
        private readonly IBaselineProcessService _blProcessService;
        private readonly IBaseRepository<BlAuditLog> _blAuditLogRepo;
        private string _username;

        public PhattvBLProcessService(
            ILogger<PhattvBLProcessService> logger,
            IBaseRepository<BlBlsettingInformation> blSettingInfoRepo,
            IBaseRepository<BlBlsettingProcess> blSettingProcessRepo,
            IBaseRepository<BlBlsettingTransactionStatus> blSettingTransactionStatusRepo,
            IBaseRepository<BlBlsettingProcessPending> blSettingProcessPendingRepo,
            IBaseRepository<BlBlsettingEmail> blSettingEmailRepo,
            IBaseRepository<BlBlprocess> blProcessRepo,
            IMapper mapper,
            IBaselineSettingService settingService,
            ISchedulerFactory schedulerFactory,
            IClientService clientService,
            IBaseRepository<SaleCalendarHoliday> holidayRepo,
            IBaseRepository<SaleCalendar> salesCalendarRepo,
            IBaselineProcessService blProcessService,
            IBaseRepository<BlAuditLog> blAuditLogRepo
            )
        {
            _logger = logger;
            _blSettingInfoRepo = blSettingInfoRepo;
            _blSettingProcessRepo = blSettingProcessRepo;
            _blSettingTransactionStatusRepo = blSettingTransactionStatusRepo;
            _blSettingProcessPendingRepo = blSettingProcessPendingRepo;
            _blSettingEmailRepo = blSettingEmailRepo;
            _blProcessRepo = blProcessRepo;
            _mapper = mapper;
            _settingService = settingService;
            _schedulerFactory = schedulerFactory;
            _clientService = clientService;
            _holidayRepo = holidayRepo;
            _salesCalendarRepo = salesCalendarRepo;
            _blProcessService = blProcessService;
            _blAuditLogRepo = blAuditLogRepo;
        }

        public async Task<List<DateTime>> GetBaseLineDate()
        {
            List<DateTime> listBaseLineDate = new();
            try
            {
                var setting = await _settingService.GetDetailBaselineSetting(null, true);
                if (!setting.IsSuccess || setting.Data == null) return new List<DateTime>();

                var blsetting = setting.Data;
                var blSettingInfo = blsetting.BlBlsettingInformation;
                var leadDate = blsetting.BlBlsettingInformation.LeadDate;

                var currentDate = DateTime.Now;
                var curentYear = currentDate.Year;
                // DayOfWeek curentDay = currentDate.DayOfWeek;
                var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == curentYear);
                if (salesCalendar == null) return new List<DateTime>();

                // bool isDayOff = false;
                // if (curentDay == DayOfWeek.Saturday)
                // {
                //     if (string.IsNullOrWhiteSpace(salesCalendar.IncludeWeekend)) isDayOff = true;
                // }
                // if (curentDay == DayOfWeek.Sunday)
                // {
                //     if (string.IsNullOrWhiteSpace(salesCalendar.IncludeWeekend)) isDayOff = true;
                //     if (salesCalendar.IncludeWeekend == CalendarConstant.SUN) isDayOff = true;
                // }

                // var listHoliday = salesCalendar != null ? _holidayRepo.Find(x => x.SaleCalendarId == salesCalendar.Id).ToList() : new List<SaleCalendarHoliday>();

                // if (listHoliday.Count > 0 && listHoliday.FirstOrDefault(x => x.SaleCalendarId == salesCalendar.Id && x.HolidayDate.Date == currentDate.Date) != null)
                // {
                //     isDayOff = true;
                // }

                bool isDayOff = await CheckIsDayOff(currentDate, salesCalendar);

                //ngày nghỉ
                if (isDayOff)
                {
                    //ProcessOffCount  + 1 number ngày nghỉ 
                    blSettingInfo.ProcessOffCount += 1;
                    _blSettingInfoRepo.Update(blSettingInfo);
                    return new List<DateTime>();
                }
                else
                {
                    int processOffCount = blSettingInfo.ProcessOffCount.HasValue ? blSettingInfo.ProcessOffCount.Value : 0;
                    // int processOffCount = 0;
                    double totalLeadDate = leadDate.Value + processOffCount;
                    double subtractDays = (double)(0 - totalLeadDate);
                    var baseLineDate = currentDate.AddDays(subtractDays);
                    listBaseLineDate.Add(baseLineDate);
                    if ((int)totalLeadDate > leadDate)
                    {
                        var blDayoffCheck = await CheckIsDayOff(baseLineDate, salesCalendar);

                        if (blDayoffCheck)
                        {
                            for (int i = 1; i < processOffCount;)
                            {
                                processOffCount--;
                                totalLeadDate = leadDate.Value + processOffCount;
                                subtractDays = (double)(0 - totalLeadDate);
                                listBaseLineDate.Add(currentDate.AddDays(subtractDays));
                            }
                        }
                    }
                    return listBaseLineDate;
                }
                // return dateReturn;
            }
            catch (System.Exception ex)
            {
                return new List<DateTime>();
            }
        }


        private async Task<bool> CheckIsDayOff(DateTime currentDate, SaleCalendar salesCalendar)
        {
            try
            {
                var curentDay = currentDate.DayOfWeek;
                var curentYear = currentDate.Year;
                bool isDayOff = false;

                // var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == curentYear);
                // if (salesCalendar == null) return true;

                if (curentDay == DayOfWeek.Saturday)
                {
                    if (string.IsNullOrWhiteSpace(salesCalendar.IncludeWeekend)) isDayOff = true;
                }
                if (curentDay == DayOfWeek.Sunday)
                {
                    if (string.IsNullOrWhiteSpace(salesCalendar.IncludeWeekend)) isDayOff = true;
                    if (salesCalendar.IncludeWeekend == CalendarConstant.SUN) isDayOff = true;
                }

                var listHoliday = salesCalendar != null ? _holidayRepo.Find(x => x.SaleCalendarId == salesCalendar.Id).ToList() : new List<SaleCalendarHoliday>();

                if (listHoliday.Count > 0 && listHoliday.FirstOrDefault(x => x.SaleCalendarId == salesCalendar.Id && x.HolidayDate.Date == currentDate.Date) != null)
                {
                    isDayOff = true;
                }

                return isDayOff;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }

        public async Task<BaseResultModel> HandleCronFromBLSetting()
        {
            try
            {
                var setting = await _settingService.GetDetailBaselineSetting(null, true);
                var processPendingTime = setting.Data.BlBlsettingInformation.ProcessPendingTime;
                var processTime = setting.Data.BlBlsettingInformation.ProcessTime;

                // processPendingTime = "16:30:30";
                // processTime = "18:30:30";

                var parseppt = TimeSpan.Parse(processPendingTime);
                var pptcron = "* * * ? * *";
                pptcron = $@"{parseppt.Seconds} {parseppt.Minutes} {parseppt.Hours} ? * *";

                var parsept = TimeSpan.Parse(processTime);
                var ptcron = "* * * ? * *";
                ptcron = $@"{parsept.Seconds} {parsept.Minutes} {parsept.Hours} ? * *";

                var pendingResult = await ReSchedular(new JobMetadata(Guid.NewGuid(), typeof(PendingDataProcessJob), "PendingDataProcess", pptcron, "DailyBaseLine"), parseppt);
                var processResult = await ReSchedular(new JobMetadata(Guid.NewGuid(), typeof(BaseLineProcessJob), "BaseLineProcessJob", ptcron, "DailyBaseLine"), parsept);
                // var stopInitialJob = await DeleteJob(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "* * * ? * *", "DailyBaseLine"));
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "OK"
                };
            }
            catch (System.Exception ex)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }


        public async Task<BaseResultModel> BLProcessExcecution()
        {
            try
            {
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "OK"
                };
            }
            catch (System.Exception ex)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        public ITrigger ReTriggered(ITrigger oldTrigger, string cronExpression)
        {
            var builder = oldTrigger.GetTriggerBuilder();
            builder = builder.WithCronSchedule(cronExpression);

            var newTrigger = builder.Build();
            var simpleTrigger = newTrigger as ISimpleTrigger;
            if (simpleTrigger != null)
            {
                var trigger = oldTrigger as ISimpleTrigger;
                if (trigger != null)
                    simpleTrigger.TimesTriggered = trigger.TimesTriggered;
            }
            return newTrigger;
        }

        public async Task<bool> ReSchedular(JobMetadata jobMetadata, TimeSpan timeCron)
        {
            try
            {

                Scheduler = await _schedulerFactory.GetScheduler();
                var trigger = await Scheduler.GetTrigger(new TriggerKey(jobMetadata.JobName, jobMetadata.JobGroup));
                var jobKey = new JobKey(jobMetadata.JobName, jobMetadata.JobGroup);

                if (!(await Scheduler.CheckExists(jobKey)))
                {
                    IJobDetail jobDetail = QuartzHelper.CreateJob(jobMetadata);
                    //Create trigger
                    if (trigger == null)
                    {
                        trigger = QuartzHelper.CreateTrigger(jobMetadata);
                    }
                    //Schedule job
                    Scheduler.ScheduleJob(jobDetail, trigger, new CancellationToken()).GetAwaiter();
                    // Create Job
                }
                else
                {

                    //Check có đang setting trùng giờ hay k, có skip , không có > reschedule
                    var triggerOfJob = await Scheduler.GetTriggersOfJob(jobKey);
                    var cronTrigger = triggerOfJob.FirstOrDefault();
                    TimeSpan startTime = cronTrigger.StartTimeUtc.TimeOfDay;
                    if (startTime.Equals(timeCron))
                    {
                        return true;
                    }


                    //check có đang hoạt động hay k
                    //Có , đợi

                    // Không , reschedule
                    await Scheduler.RescheduleJob(trigger.Key, ReTriggered(trigger, jobMetadata.CronExpression));
                }
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }


        public async Task<bool> DeleteJob(JobMetadata jobMetadata)
        {
            try
            {
                Scheduler = await _schedulerFactory.GetScheduler();
                // var trigger = await Scheduler.GetTrigger(new TriggerKey(jobMetadata.JobName, jobMetadata.JobGroup));
                var jobKey = new JobKey(jobMetadata.JobName, jobMetadata.JobGroup);
                await Scheduler.DeleteJob(jobKey);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }

        public async Task<BaseResultModel> HandleProcessPendingData(List<DateTime> listBaseLineDate)
        {
            try
            {
                var setting = await _settingService.GetDetailBaselineSetting(null, true);
                var processPendingSetting = setting.Data.ProcessPendings;
                if (!setting.Data.BlBlsettingInformation.IsProcessPendingData.Value)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = true,
                        Message = "OK"
                    };
                }
                foreach (var baseLineDate in listBaseLineDate)
                {
                    var req = new OrderPendingTransModel
                    {
                        BaselineDate = baseLineDate,
                        Detail = processPendingSetting.Select(x => new OrderPendingTransDetailModel
                        {
                            FromStatus = x.FromStatus,
                            ToStatus = x.ToStatus
                        }).ToList()
                    };
                    var handlePendingSOResult = await _clientService.CommonRequestAsync<BaseResultModel>(CommonData.SystemUrlCode.SaleOrderAPI, $"/SO/TransactionPendingData", Method.POST, null, req);
                }
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "OK"
                };

            }
            catch (System.Exception ex)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }


        public async Task<BaseResultModel> HandleBaseLineProcess(List<DateTime> listBaseLineDate)
        {
            try
            {

                var setting = await _settingService.GetDetailBaselineSetting(null, true);
                var blSettingProcess = setting.Data.BaseLineProcesses;
                var blSettingInfo = setting.Data.BlBlsettingInformation;
                var listSequentialProcess = blSettingProcess.Where(x => x.IsSequentialProcessing == true).OrderBy(x => x.Priority).ToList();
                var listAsynchronousProcess = blSettingProcess.Where(x => x.IsSequentialProcessing == false).ToList();

                foreach (var baseLineDate in listBaseLineDate)
                {
                    string blDate = baseLineDate.ToString("YYYY-MM-DD");
                    foreach (var sequentialProcess in listSequentialProcess)
                    {
                        switch (sequentialProcess.ProcessCode)
                        {
                            case BlProcessConst.SOPROCESS:
                                await _blProcessService.ProcessSO(blDate, blSettingInfo.SettingRef);
                                break;
                            case BlProcessConst.POPROCESS:
                                await _blProcessService.ProcessPO(blDate, blSettingInfo.SettingRef);
                                break;
                            case BlProcessConst.IN_ISSUE:
                                await _blProcessService.ProcessInvIssue(blDate, blSettingInfo.SettingRef, BaselineType.DAILY);
                                break;
                            case BlProcessConst.IN_RECEIPT:
                                await _blProcessService.ProcessInvReceipt(blDate, blSettingInfo.SettingRef, BaselineType.DAILY);
                                break;
                            case BlProcessConst.BL_CLOSE_QTY:
                                await _blProcessService.ProcessInvCloseQty(blDate, blSettingInfo.SettingRef);
                                break;
                            default:
                                break;
                        }
                    }

                    foreach (var asynchronousProcess in listAsynchronousProcess)
                    {
                        switch (asynchronousProcess.ProcessCode)
                        {
                            case BlProcessConst.SOPROCESS:
                                _blProcessService.ProcessSO(blDate, blSettingInfo.SettingRef);
                                break;
                            case BlProcessConst.POPROCESS:
                                _blProcessService.ProcessPO(blDate, blSettingInfo.SettingRef);
                                break;
                            case BlProcessConst.IN_ISSUE:
                                _blProcessService.ProcessInvIssue(blDate, blSettingInfo.SettingRef, BaselineType.DAILY);
                                break;
                            case BlProcessConst.IN_RECEIPT:
                                _blProcessService.ProcessInvReceipt(blDate, blSettingInfo.SettingRef, BaselineType.DAILY);
                                break;
                            case BlProcessConst.BL_CLOSE_QTY:
                                _blProcessService.ProcessInvCloseQty(blDate, blSettingInfo.SettingRef);
                                break;
                            default:
                                break;
                        }
                    }
                }
                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "OK"
                };
            }
            catch (System.Exception ex)
            {
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }

        #region AuditLog
        private void CreateAuditLog(BaseResultModel resultLog, DateTime baseLineDate, string settingRef, string processCode)
        {
            _blAuditLogRepo.Insert(new BlAuditLog
            {
                Id = Guid.NewGuid(),
                BaselineSettingRef = settingRef,
                BaselineDate = baseLineDate,
                CreatedDate = DateTime.Now,
                CreatedBy = _username,
                ProcessCode = processCode,
                IsSuccess = resultLog.IsSuccess,
                Description = resultLog.Message,
                FinishTime = DateTime.Now,
                UpdatedBy = null
            });
            return;
        }
        #endregion
    }
}
