using Quartz;
using RDOS.BaseLine.Models;
using RDOS.BaseLine.Service.Interface;
using RDOS.BaseLine.Services;

namespace RDOS.BaseLine.Jobs
{
    public class InitialJob : IJob
    {
        public InitialJob()
        {

        }
        public async Task Execute(IJobExecutionContext context)
        {

            InitialService initialService = new();
            var initialResult = initialService.InitialCron().Result;
            return;
        }


    }
}
