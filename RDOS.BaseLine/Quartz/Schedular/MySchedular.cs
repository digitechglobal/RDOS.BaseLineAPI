using RDOS.BaseLine.Models;
using Quartz;
using Quartz.Spi;
using RDOS.BaseLine.Service.Interface;

namespace RDOS.BaseLine.Schedular
{
    public class MySchedular : IHostedService , IMySchedular
    {
        public IScheduler Scheduler { get; set; }
        private readonly IJobFactory _jobFactory;
        private readonly List<JobMetadata> _jobMetadatas;
        private readonly ISchedulerFactory _schedulerFactory;

        public MySchedular(ISchedulerFactory schedulerFactory, List<JobMetadata> jobMetadatas, IJobFactory jobFactory)
        {
            _jobFactory = jobFactory;
            _jobMetadatas = jobMetadatas;
            _schedulerFactory = schedulerFactory;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            //Creating schedular
            Scheduler = await _schedulerFactory.GetScheduler();
            Scheduler.JobFactory = _jobFactory;
            _jobMetadatas?.ForEach(_jobMetadata =>
            {
                //Create Job
                IJobDetail jobDetail = CreateJob(_jobMetadata);
                //Create trigger
                ITrigger trigger = CreateTrigger(_jobMetadata);
                //Schedule job
                Scheduler.ScheduleJob(jobDetail, trigger, cancellationToken).GetAwaiter();
            });
            //Start the schedular
            await Scheduler.Start(cancellationToken);
        }

        private ITrigger CreateTrigger(JobMetadata jobMetadata)
        {
            return TriggerBuilder.Create()
                .WithIdentity(jobMetadata.JobName, jobMetadata.JobGroup)
                .ForJob(jobMetadata.JobName, jobMetadata.JobGroup)
                .WithDescription(jobMetadata.JobName)
                .WithCronSchedule(jobMetadata.CronExpression)
                //.WithCronSchedule("0 38 17 * * ?")
                .Build();
        }

        private IJobDetail CreateJob(JobMetadata jobMetadata)
        {
            return JobBuilder.Create(jobMetadata.JobType)
                  .WithIdentity(jobMetadata.JobName, jobMetadata.JobGroup)
                  .WithDescription(jobMetadata.JobName)
                  .Build();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
