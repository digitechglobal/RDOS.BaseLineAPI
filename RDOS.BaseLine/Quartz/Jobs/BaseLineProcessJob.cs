using Quartz;
using RDOS.BaseLine.Constants;
using RDOS.BaseLine.Service.Interface;
using RDOS.BaseLine.Services;
using static RDOS.BaseLine.Constants.Constants;

namespace RDOS.BaseLine.Jobs
{
    [DisallowConcurrentExecution]
    public class BaseLineProcessJob : IJob
    {
        public BaseLineProcessJob()
        {
        }
        public async Task Execute(IJobExecutionContext context)
        {
            InitialService initialService = new();
            var initialResult = initialService.HandleBaseLineProcess().Result;
            return;
            // return Task.CompletedTask;
        }
    }
}
