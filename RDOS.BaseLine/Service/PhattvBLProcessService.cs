using AutoMapper;
using RDOS.BaseLine.Jobs;
using RDOS.BaseLine.Models;
using nProx.Helpers.Services.Repository;
using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service.Interface;
using static RDOS.BaseLine.Models.Results;
using Sys.Common.Helper;
using RDOS.BaseLine.Services.Interface;
using SysAdmin.Models.StaticValue;
using RestSharp;
using RDOS.BaseLine.Models.Result;
using static RDOS.BaseLine.Constants.Constants;
using nProx.Helpers.Dapper;
using Dapper;
using RDOS.BaseLine.Models.Request;
using RestSharp.Extensions;

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
        private readonly IBaseRepository<BlHistory> _blHistoryRepo;
        private readonly IBaseRepository<BlOutletAccumulate> _blOutletAccumulateRepo;
        private readonly IBaseRepository<BlNormOfBussinessModel> _blNormOfBussinessModelRepo;
        private readonly IMapper _mapper;

        private readonly IBaselineSettingService _settingService;
        private readonly ISchedulerFactory _schedulerFactory;
        public IScheduler Scheduler { get; set; }
        public readonly IClientService _clientService;
        private readonly IBaseRepository<SaleCalendarHoliday> _holidayRepo;
        private readonly IBaseRepository<SaleCalendar> _salesCalendarRepo;
        private readonly IBaselineProcessService _blProcessService;
        private readonly IBaseRepository<BlAuditLog> _blAuditLogRepo;
        private readonly IBaseRepository<BlRawSo> _blRawSo;
        private readonly IBaseRepository<SaleCalendarGenerate> _saleCalendarGenerateRepo;
        private readonly IBaseRepository<Kpisetting> _kpiSettingRepo;
        private readonly IBaseRepository<KpivisitFrequency> _kpivisitFrequencyRepo;
        private readonly IDapperRepositories _dapper;
        private readonly IBaseRepository<ScSalesOrganizationStructure> _salesOrgRepo;
        private string _token;
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
            IBaseRepository<BlAuditLog> blAuditLogRepo,
            IBaseRepository<BlRawSo> blRawSo,
            IBaseRepository<BlHistory> blHistoryRepo,
            IBaseRepository<SaleCalendarGenerate> saleCalendarGenerateRepo,
            IBaseRepository<BlOutletAccumulate> blOutletAccumulateRepo,
            IDapperRepositories dapper,
            IBaseRepository<ScSalesOrganizationStructure> salesOrgRepo,
            IBaseRepository<Kpisetting> kpiSettingRepo,
            IBaseRepository<BlNormOfBussinessModel> blNormOfBussinessModelRepo,
            IBaseRepository<KpivisitFrequency> kpivisitFrequencyRepo
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
            _blRawSo = blRawSo;
            _blHistoryRepo = blHistoryRepo;
            _saleCalendarGenerateRepo = saleCalendarGenerateRepo;
            _blOutletAccumulateRepo = blOutletAccumulateRepo;
            _dapper = dapper;
            _salesOrgRepo = salesOrgRepo;
            _kpiSettingRepo = kpiSettingRepo;
            _blNormOfBussinessModelRepo = blNormOfBussinessModelRepo;
            _kpivisitFrequencyRepo = kpivisitFrequencyRepo;
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
                var stopInitialJob = await DeleteJob(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "* * * ? * *", "DailyBaseLine"));
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

                    // Scheduler.PauseJob()
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

        public async Task<BaseResultModel> HandleProcessPendingData()
        {
            try
            {
                var listBaseLineDate = await GetBaseLineDate();

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

        public async Task<BaseResultModel> ValidateRebaseline(BaselineProcessRequest dataInput)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dataInput.SalesOrgCode))
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "Sales org code cannot null"
                    };
                }

                if (dataInput.Scope.ToLower() != ScopeTypeConst.BRANCH.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.REGION.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.SUBREGION.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.AREA.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.SUBAREA.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.ROUTEZONE.ToLower() &&
                    dataInput.Scope.ToLower() != ScopeTypeConst.DSA.ToLower())
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "Scope is incorrect"
                    };
                }

                if (dataInput.ValueCodes == null || dataInput.ValueCodes != null && dataInput.ValueCodes.Count == 0)
                {
                    return new BaseResultModel
                    {
                        IsSuccess = false,
                        Code = 400,
                        Message = "List value code cannot null"
                    };
                }

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Validated"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message ?? ex.Message);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message,
                };
            }
        }

        public async Task<BaseResultModel> HandleBaseLineProcess(BaselineProcessRequest dataRequest)
        {
            try
            {
                var historyRefNumber = await GenRefNumber();
                List<DateTime>? listBaseLineDate = new List<DateTime>();
                if (dataRequest.Scope.ToLower() == ScopeTypeConst.ALL.ToLower() && dataRequest.Type.ToLower() == BaselineType.DAILY.ToLower())
                {
                    listBaseLineDate = await GetBaseLineDate();
                }
                else
                {
                    listBaseLineDate.Add(dataRequest.BaselineDate);
                }
                var startTime = DateTime.Now;
                var setting = await _settingService.GetDetailBaselineSetting(null, true);
                var blSettingProcess = setting.Data.BaseLineProcesses;
                var blSettingInfo = setting.Data.BlBlsettingInformation;
                var listSequentialProcess = blSettingProcess.Where(x => x.IsSequentialProcessing == true).OrderBy(x => x.Priority).ToList();
                var listAsynchronousProcess = blSettingProcess.Where(x => x.IsSequentialProcessing == false).ToList();

                foreach (var baseLineDate in listBaseLineDate)
                {
                    string blDate = baseLineDate.ToString("yyyy-MM-dd");
                    var dataReq = new ProcessRequest()
                    {
                        BaselineDate = blDate,
                        SettingRef = blSettingInfo.SettingRef,
                        Type = dataRequest.Scope.ToLower() == ScopeTypeConst.ALL.ToLower() ? null : dataRequest.Scope,
                        ValueCodes = dataRequest.Scope.ToLower() == ScopeTypeConst.ALL.ToLower() ? null : dataRequest.ValueCodes,
                        SalesOrgCode = dataRequest.Scope.ToLower() == ScopeTypeConst.ALL.ToLower() ? null : dataRequest.SalesOrgCode,
                        HistoryRefNumber = historyRefNumber
                    };
                    foreach (var sequentialProcess in listSequentialProcess)
                    {
                        switch (sequentialProcess.ProcessCode)
                        {
                            case BlProcessConst.SOPROCESS:
                                await _blProcessService.ProcessSO(dataReq);
                                break;
                            case BlProcessConst.POPROCESS:
                                await _blProcessService.ProcessPO(dataReq);
                                break;
                            case BlProcessConst.IN_ISSUE:
                                await _blProcessService.ProcessInvIssue(dataReq, BaselineType.DAILY);
                                break;
                            case BlProcessConst.IN_RECEIPT:
                                await _blProcessService.ProcessInvReceipt(dataReq, BaselineType.DAILY);
                                break;
                            case BlProcessConst.BL_CLOSE_QTY:
                                await _blProcessService.ProcessInvCloseQty(dataReq);
                                break;
                            case BlProcessConst.BL_SAFE_STOCK_ACESSMENT:
                                await _blProcessService.ProcessSafetyStockAssessment(dataReq);
                                break;
                            case BlProcessConst.AVERATE_DAILY_RUNNING_SALE:
                                await _blProcessService.ProcessRunningSales(dataReq);
                                break;
                            case BlProcessConst.CAL_KPI:
                                // await _blProcessService.ProcessCaculateKPI(); --token ?
                                break;
                            case BlProcessConst.CUS_PER_DAILY:
                                await _blProcessService.ProcessCusPerDaily(dataReq);
                                break;
                            case BlProcessConst.OUTLET_ACCUMULATE:
                                await _blProcessService.ProcessOutletAccumulate(dataReq);
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
                                _blProcessService.ProcessSO(dataReq);
                                break;
                            case BlProcessConst.POPROCESS:

                                _blProcessService.ProcessPO(dataReq);
                                break;
                            case BlProcessConst.IN_ISSUE:
                                _blProcessService.ProcessInvIssue(dataReq, BaselineType.DAILY);
                                break;
                            case BlProcessConst.IN_RECEIPT:
                                _blProcessService.ProcessInvReceipt(dataReq, BaselineType.DAILY);
                                break;
                            case BlProcessConst.BL_CLOSE_QTY:
                                _blProcessService.ProcessInvCloseQty(dataReq);
                                break;
                            case BlProcessConst.BL_SAFE_STOCK_ACESSMENT:
                                _blProcessService.ProcessSafetyStockAssessment(dataReq);
                                break;
                            case BlProcessConst.AVERATE_DAILY_RUNNING_SALE:
                                _blProcessService.ProcessRunningSales(dataReq);
                                break;
                            case BlProcessConst.CAL_KPI:
                                //  _blProcessService.ProcessCaculateKPI(); --token ?
                                break;
                            case BlProcessConst.CUS_PER_DAILY:
                                _blProcessService.ProcessCusPerDaily(dataReq);
                                break;
                            case BlProcessConst.OUTLET_ACCUMULATE:
                                _blProcessService.ProcessOutletAccumulate(dataReq);
                                break;
                            default:
                                break;
                        }
                    }

                    //History
                    var listAuditLog = _blAuditLogRepo.Find(x => x.BaselineDate.Value.Date == baseLineDate.Date && x.RefNumber == historyRefNumber);
                    var salesCalendar = _salesCalendarRepo.FirstOrDefault(x => x.SaleYear == baseLineDate.Year);
                    var salesPeriod = _saleCalendarGenerateRepo.FirstOrDefault(x => x.SaleCalendarId == salesCalendar.Id &&
                                                                 x.Type == CalendarConstant.MONTH &&
                                                                 x.StartDate.Value.Date <= baseLineDate.Date &&
                                                                 x.EndDate.Value.Date >= baseLineDate.Date);

                    ScSalesOrganizationStructure? salesOrgInfo = null;
                    if (!string.IsNullOrWhiteSpace(dataRequest.SalesOrgCode))
                    {
                        salesOrgInfo = _salesOrgRepo.FirstOrDefault(x => x.Code == dataRequest.SalesOrgCode && !x.IsDeleted);
                    }

                    _blHistoryRepo.Insert(new BlHistory
                    {
                        Id = Guid.NewGuid(),
                        BaselineSettingRef = blSettingInfo.SettingRef,
                        BaselineDate = baseLineDate,
                        SalesPeriod = salesPeriod.Code,
                        StartTimeDate = startTime,
                        EndTimeDate = DateTime.Now,
                        IsCompleted = listAuditLog.Any(x => !x.IsSuccess.Value) ? false : true,
                        Type = dataRequest.Type,
                        Scope = dataRequest.Scope,
                        SalesOrgId = dataRequest.SalesOrgCode,
                        SalesOrgDesc = salesOrgInfo != null ? salesOrgInfo.Description : null,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = null,
                        CreatedBy = dataRequest.ByUser,
                        UpdatedBy = null,
                        RefNumber = historyRefNumber
                    });
                }

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Message = "Successfully"
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

        private async Task<string> GenRefNumber()
        {
            var listData = _blHistoryRepo.GetAll();
            return GenRefNumber(listData.Count(), listData);
            string GenRefNumber(int number, IEnumerable<BlHistory> listData)
            {
                var refNew = PrefixRef.PREFIX_HISTORY + number;
                var checkExist = listData.FirstOrDefault(x => x.RefNumber == refNew);
                if (checkExist != null)
                {
                    number++;
                    return GenRefNumber(number, listData);
                }
                else
                {
                    return refNew;
                }
            }
        }





























































































































































































































































































































































































































































































































































































































































































































































































































































































































        public async Task<BaseResultModel> HandleMonthlyBaseLine(MonthlyBaseLineReqModel req, string token, string username)
        {
            _token = token;
            _username = username;
            var insertHistory = await CommonInsertHistory(new BlHistory
            {
                Id = Guid.NewGuid(),
                BaselineSettingRef = req.settingRef,
                BaselineDate = null,
                SalesPeriod = req.salesPeriod,
                StartTimeDate = DateTime.Now,
                EndTimeDate = null,
                IsCompleted = false,
                Type = BaselineType.MONTHLY,
                Scope = ScopeTypeConst.ALL,
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
                CreatedBy = username,
                UpdatedBy = null,
                SalesOrgId = req.saleOrgId,
                SalesOrgDesc = req.SalesOrgDesc,
                // RefNumber = ,
            });

            try
            {

                #region PnM
                List<BlPnM> insertPnMList = new();
                var kpiSetting = _kpiSettingRepo.Find(x => x.SaleYear == DateTime.Now.Year).FirstOrDefault();
                var kpiFrequencySettings = kpiSetting != null ? _kpivisitFrequencyRepo.Find(x => x.KpisettingId == kpiSetting.Id).ToList() : new List<KpivisitFrequency>();
                int n = 0;
                if (kpiSetting != null)
                {
                    n = kpiSetting.BasedPastMonths;
                }
                var saleCalendar = _salesCalendarRepo.Find(x => x.SaleYear == req.salesYear).FirstOrDefault();
                var calendarGenerates = saleCalendar != null ? _saleCalendarGenerateRepo.Find(x => x.Type == CalendarConstant.MONTH && x.SaleCalendarId == saleCalendar.Id && x.Ordinal <= req.ordinal && x.Ordinal > req.ordinal - n).ToList() : new List<SaleCalendarGenerate>();
                List<string> salePeriodList = new List<string> { req.salesPeriod };
                if (calendarGenerates != null && calendarGenerates.Count > 0)
                {
                    salePeriodList.AddRange(calendarGenerates.Select(x => x.Code).ToList());
                }


                // Function query
                var queryvol = @"SELECT * FROM collectoutletpnmbyvol(@salesperiod, @saleorgid))";
                var queryrev = @"SELECT * FROM collectoutletpnmbyrev(@salesperiod, @saleorgid))";

                var listVolData = new List<BlPnM>();
                var listRevData = new List<BlPnM>();

                //Vol
                // Excute query
                foreach (var item in salePeriodList)
                {
                    // Handle parameter
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@salesperiod", req.salesPeriod);
                    parameters.Add("@saleorgid", req.saleOrgId);
                    var listVol = ((List<BlPnM>)_dapper.QueryWithParams<BlPnM>(queryvol, parameters));
                    if (listVol != null && listVol.Count > 0)
                    {
                        listVolData.AddRange(listVol);
                    }
                    var listRev = ((List<BlPnM>)_dapper.QueryWithParams<BlPnM>(queryrev, parameters));
                    if (listRev != null && listRev.Count > 0)
                    {
                        listRevData.AddRange(listRev);
                    }


                }

                var groupeVoldData = listVolData.GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => new BlPnM
                {
                    Id = Guid.NewGuid(),
                    SalesPeriod = req.salesPeriod,
                    CustomerId = x.Key.CustomerId,
                    CustomerName = x.Select(x => x.CustomerName).FirstOrDefault(),
                    CustomerShiptoId = x.Key.CustomerShiptoId,
                    CustomerShiptoName = x.Select(x => x.CustomerShiptoName).FirstOrDefault(),
                    ValueType = BLAccumulateConst.VOL, //số lượng
                    Value = x.Sum(a => a.Value) / x.GroupBy(x => x.SalesPeriod).Select(x => x.FirstOrDefault()).Count(),
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    CreatedBy = null,
                    UpdatedBy = null,
                }).ToList();


                // Rev
                var groupeRevdData = listRevData.GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => new BlPnM
                {
                    Id = Guid.NewGuid(),
                    SalesPeriod = req.salesPeriod,
                    CustomerId = x.Key.CustomerId,
                    CustomerName = x.Select(x => x.CustomerName).FirstOrDefault(),
                    CustomerShiptoId = x.Key.CustomerShiptoId,
                    CustomerShiptoName = x.Select(x => x.CustomerShiptoName).FirstOrDefault(),
                    ValueType = BLAccumulateConst.REV, //số lượng
                    Value = x.Sum(a => a.Value) / x.GroupBy(x => x.SalesPeriod).Select(x => x.FirstOrDefault()).Count(),
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    CreatedBy = null,
                    UpdatedBy = null,
                }).ToList();

                #endregion

                var queryShiptoList = @"SELECT * FROM collectshiptobycus04()";
                // Handle parameter
                DynamicParameters queryShiptoListparameters = new DynamicParameters();
                // parameters.Add("@salesperiod", salesPeriod);
                var listAttByCUS04 = ((List<ActiveAttCUS04Model>)_dapper.QueryWithParams<ActiveAttCUS04Model>(queryShiptoList, queryShiptoListparameters));
                if (listAttByCUS04 != null && listAttByCUS04.Count > 0)
                {
                    var listRawSo = _blRawSo.Find(x => x.SalesPeriodId == req.salesPeriod).ToList();
                    // var GroupedShiptohasByed = listRawSo.Where(x => x.Status == StatusSOConst.DELIVERED || x.Status == StatusSOConst.PARTIALDELIVERED).GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => x.First()).ToList();
                    var listNorm = new List<BlNormOfBussinessModel>();
                    foreach (var model in listAttByCUS04)
                    {
                        var rawSobyAttribute = listRawSo.Where(x => x.CusShiptoAttributeValueId4 == model.Code).ToList();
                        var GroupedShiptohasByed = rawSobyAttribute.Where(x => x.Status == StatusSOConst.DELIVERED || x.Status == StatusSOConst.PARTIALDELIVERED).GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => x.First()).ToList();

                        //VPO
                        decimal vpoValue = (decimal)(rawSobyAttribute.Sum(x => x.OrderBaseQuantities) / GroupedShiptohasByed.Count);
                        var normVPO = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "VPO",
                            Sidesc = "Value of Outlet",
                            Value = vpoValue.ToString(),
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        // %PC
                        decimal pcValue = rawSobyAttribute.Where(x => x.Status == StatusSOConst.DELIVERED || x.Status == StatusSOConst.PARTIALDELIVERED).GroupBy(x => x.ReferenceRefNbr).Select(x => x.First()).ToList().Count * 100 / rawSobyAttribute.GroupBy(x => x.ReferenceRefNbr).Select(x => x.First()).ToList().Count;
                        var normPC = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "%PC",
                            Sidesc = "% Productive Call",
                            Value = pcValue.ToString() + "%",
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        // %ASO	
                        decimal ASOValue = GroupedShiptohasByed.Count * 100 / rawSobyAttribute.GroupBy(x => new { x.CustomerId, x.CustomerShiptoId }).Select(x => x.First()).ToList().Count;
                        var normASO = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "%ASO",
                            Sidesc = "% Active Selling Outlet",
                            Value = ASOValue.ToString() + "%",
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        // LPPC		- shippedExtend / Count of Refnumber
                        decimal LPPCValue = (decimal)(rawSobyAttribute.Sum(x => x.ShippedBaseQuantities) / rawSobyAttribute.Where(x => x.Status == StatusSOConst.DELIVERED || x.Status == StatusSOConst.PARTIALDELIVERED).GroupBy(x => x.OrderRefNumber).Select(x => x.First()).Count());
                        var normLPPC = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "LPPC",
                            Sidesc = "Line Per Productivity Call",
                            Value = LPPCValue.ToString(),
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        int visitFrequency = kpiFrequencySettings.Where(x => x.BusinessModel == model.Code).Select(x => x.VisitFrequency).FirstOrDefault();// temp - get later 
                        //LPPC Value  - (VPO / (%PC * Visit frequency)) / LPPC. * Visit frequency theo từng Business Model được lấy từ định nghĩa KPIs setting								
                        decimal LPPCValueCal = visitFrequency != 0 ? (vpoValue / (pcValue * visitFrequency)) / LPPCValue : 0;
                        var normLPPCValue = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "LPPCValue",
                            Sidesc = "Line Per Productivity Call Value",
                            Value = LPPCValueCal.ToString(),
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        //Drop Size - VPO / ( %PC * Visit frequency). * Visit frequency theo từng Business Model được lấy từ định nghĩa KPIs setting								
                        decimal DropsizeValue = visitFrequency != 0 ? vpoValue / (pcValue * visitFrequency) : 0;
                        var normDropSize = new BlNormOfBussinessModel
                        {
                            Id = Guid.NewGuid(),
                            SalesPeriod = req.salesPeriod,
                            BusinessModelId = model.Code,
                            BusinessModelDesr = null,
                            Siid = "DropSize",
                            Sidesc = "Drop Size",
                            Value = DropsizeValue.ToString(),
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            CreatedBy = null,
                            UpdatedBy = null,
                        };

                        listNorm.Add(normASO);
                        listNorm.Add(normDropSize);
                        listNorm.Add(normLPPC);
                        listNorm.Add(normLPPCValue);
                        listNorm.Add(normPC);
                        listNorm.Add(normVPO);
                    }

                    _blNormOfBussinessModelRepo.InsertMany(listNorm);
                }

                //KPI
                var currentSalesCalendar = calendarGenerates.Where(x => x.Code == req.salesPeriod).FirstOrDefault();
                if (currentSalesCalendar != null)
                {
                    for (DateTime i = currentSalesCalendar.StartDate.Value.Date; i <= currentSalesCalendar.EndDate.Value.Date; i.AddDays(1))
                    {
                        await _blProcessService.ProcessSoKPI(i, _token);
                    };
                }


                insertHistory.UpdatedBy = username;
                insertHistory.UpdatedDate = DateTime.Now;
                insertHistory.EndTimeDate = DateTime.Now;



                insertHistory.IsCompleted = true;
                _blHistoryRepo.Update(insertHistory);

                return new BaseResultModel
                {
                    IsSuccess = true,
                    Code = 200,
                    Message = "Successfully",
                };
            }
            catch (System.Exception ex)
            {
                insertHistory.UpdatedBy = username;
                insertHistory.UpdatedDate = DateTime.Now;
                insertHistory.EndTimeDate = DateTime.Now;

                insertHistory.IsCompleted = false;
                _blHistoryRepo.Update(insertHistory);
                return new BaseResultModel
                {
                    IsSuccess = false,
                    Code = 500,
                    Message = ex.InnerException?.Message ?? ex.Message + Environment.NewLine + ex.InnerException?.StackTrace ?? ex.StackTrace,
                };
            }
        }


        public async Task<BlHistory> CommonInsertHistory(BlHistory model)
        {
            try
            {
                var historyRefNumber = await GenRefNumber();
                model.RefNumber = historyRefNumber;
                var result = _blHistoryRepo.Insert(model);
                return result;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

    }
}
