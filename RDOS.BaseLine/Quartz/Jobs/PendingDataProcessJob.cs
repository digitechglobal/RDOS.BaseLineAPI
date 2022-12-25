using Quartz;
using RDOS.BaseLine.Service.Interface;

namespace RDOS.BaseLine.Jobs
{
    public class PendingDataProcessJob : IJob
    {
        private readonly ILogger<PendingDataProcessJob> _logger;
        private readonly IPhattvBLProcessService _phattvservice;
        public PendingDataProcessJob(ILogger<PendingDataProcessJob> logger, IPhattvBLProcessService phattvservice)
        {
            this._logger = logger;
            this._phattvservice = phattvservice;
        }
        public Task Execute(IJobExecutionContext context)
        {
            var baseLineDate = _phattvservice.GetBaseLineDate().Result;
            if (baseLineDate.HasValue)
            {
                _phattvservice.HandleProcessPendingData(baseLineDate.Value);
            }
            return Task.CompletedTask;
        }
    }
}
