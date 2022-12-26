using Quartz;
using RDOS.BaseLine.Models;
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
        public async Task Execute(IJobExecutionContext context)
        {
            await _phattvservice.HandleCronFromBLSetting();
            await _phattvservice.DeleteJob(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "* * * ? * *", "DailyBaseLine"));
            return;
        }


    }
}
