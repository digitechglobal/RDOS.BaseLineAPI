using Quartz;
using RDOS.BaseLine.Service.Interface;

namespace RDOS.BaseLine.Jobs
{
    public class InitialJob : IJob
    {
        private readonly ILogger<InitialJob> _logger;
        private readonly IPhattvBLProcessService _phattvservice;
        public InitialJob(ILogger<InitialJob> logger, IPhattvBLProcessService phattvservice)
        {
            this._logger = logger;
            this._phattvservice = phattvservice;
        }
        public Task Execute(IJobExecutionContext context)
        {
            var bruh = _phattvservice.HandleCronFromBLSetting();
            var a = bruh.Result.Message;
            _logger.LogInformation($"Log Job: at {DateTime.Now} and Jobtype: {context.JobDetail.JobType}");
            return Task.CompletedTask;
        }


    }
}
