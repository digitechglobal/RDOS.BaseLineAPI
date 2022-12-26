using Quartz;
using RDOS.BaseLine.Service.Interface;

namespace RDOS.BaseLine.Jobs
{
    public class BaseLineProcessJob : IJob
    {
        private readonly ILogger<BaseLineProcessJob> _logger;
        private readonly IPhattvBLProcessService _phattvservice;
        public BaseLineProcessJob(ILogger<BaseLineProcessJob> logger, IPhattvBLProcessService phattvservice)
        {
            this._logger = logger;
            this._phattvservice = phattvservice;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            var baseLineDate = _phattvservice.GetBaseLineDate().Result;
            if (baseLineDate != null && baseLineDate.Count > 0)
            {
                await _phattvservice.HandleBaseLineProcess(baseLineDate);
            }
            return;
            // return Task.CompletedTask;
        }
    }
}
