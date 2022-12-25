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
            IClientService clientService
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
        }

        public async Task<DateTime?> GetBaseLineDate()
        {
            try
            {
                var dateReturn = DateTime.Now;
                return dateReturn;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public async Task<BaseResultModel> HandleCronFromBLSetting()
        {
            try
            {
                var setting = await _settingService.GetCurrentBaselineSetting();
                var processPendingTime = setting.Data.BlBlsettingInformation.ProcessPendingTime;
                var processTime = setting.Data.BlBlsettingInformation.ProcessTime;

                // processPendingTime = "16:30:30";
                // processTime = "18:30:30";

                var parseppt = TimeSpan.Parse(processPendingTime);
                var pptcron = "* * * ? * *";
                pptcron = $@"{parseppt.Seconds} {parseppt.Minutes} {parseppt.Hours} ? * *";

                var parsept = TimeSpan.Parse(processTime);
                var ptcron = "* * * ? * *";
                ptcron = $@"{parsept.Seconds} {parsept.Minutes} {parseppt.Hours} ? * *";

                //Check processPending có đang đúng time k

                //Đúng, pass
                // không đúng, 
                //Check có đang chạy k, 
                //Có => Đợi
                var pendingResult = await ReSchedular(new JobMetadata(Guid.NewGuid(), typeof(PendingDataProcessJob), "PendingDataProcess", pptcron, "DailyBaseLine"));

                // ReSchedule
                //Check processTime có đang đúng time k
                //Đúng, pass
                // không đúng, 
                //Check có đang chạy k, 
                //Có => Đợi
                var processResult = await ReSchedular(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "BaslineProcess", ptcron, "DailyBaseLine"));
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

        public async Task<bool> ReSchedular(JobMetadata jobMetadata)
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
                    ITrigger createdTrigger = QuartzHelper.CreateTrigger(jobMetadata);
                    //Schedule job
                    Scheduler.ScheduleJob(jobDetail, createdTrigger, new CancellationToken()).GetAwaiter();
                    // Create Job
                }
                else
                {
                    //Check có đang setting trùng giờ hay k, có skip , không có > reschedule
                    
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

        public async Task<BaseResultModel> HandleProcessPendingData(DateTime baseLineDate)
        {
            try
            {
                var setting = await _settingService.GetCurrentBaselineSetting();
                var processPendingSetting = setting.Data.ProcessPendings;
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
    }
}
