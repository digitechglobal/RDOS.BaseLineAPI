﻿using Quartz;
using Quartz.Spi;

namespace RDOS.BaseLine.JobFactory
{
    public class MyJobFactory : IJobFactory
    {
        private readonly IServiceProvider service;
        public MyJobFactory(IServiceProvider serviceProvider)
        {
            service = serviceProvider;
        }
        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            var jobDetail = bundle.JobDetail;
            return (IJob)service.GetService(jobDetail.JobType);
        }

        public void ReturnJob(IJob job)
        {

        }
    }
}