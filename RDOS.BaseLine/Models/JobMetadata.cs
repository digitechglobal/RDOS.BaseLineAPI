namespace DemoCronjob.Models
{
    public class JobMetadata
    {
        public Guid JobId { get; set; }
        public Type JobType { get; set; }
        public string JobName { get; }
        public string CronExpression { get; }
        public string JobGroup { get; }
        public JobMetadata(Guid Id, Type jobType, string jobName, string cronExpression, string group)
        {
            JobId = Id;
            JobType = jobType;
            JobName = jobName;
            CronExpression = cronExpression;
            JobGroup = group;
        }
    }
}
