using Quartz;
using RDOS.BaseLine.Service.Interface;
using RDOS.BaseLine.Services;

namespace RDOS.BaseLine.Jobs
{
    public class PendingDataProcessJob : IJob
    {
        public PendingDataProcessJob()
        {
        
        }
        public async Task Execute(IJobExecutionContext context)
        {
            InitialService initialService = new();
            var initialResult = initialService.ProcessPendingData().Result;
            return;
            // return Task.CompletedTask;
        }
    }
}
