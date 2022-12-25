using RDOS.BaseLine.Models;
using Quartz;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Sys.Common.Helper
{
    public static class QuartzHelper
    {
        public static ITrigger CreateTrigger(JobMetadata jobMetadata)
        {
            return TriggerBuilder.Create()
                .WithIdentity(jobMetadata.JobName, jobMetadata.JobGroup)
                .ForJob(jobMetadata.JobName, jobMetadata.JobGroup)
                .WithDescription(jobMetadata.JobName)
                .WithCronSchedule(jobMetadata.CronExpression)
                //.WithCronSchedule("0 38 17 * * ?")
                .Build();
        }

        public static IJobDetail CreateJob(JobMetadata jobMetadata)
        {
            return JobBuilder.Create(jobMetadata.JobType)
                  .WithIdentity(jobMetadata.JobName, jobMetadata.JobGroup)
                  .WithDescription(jobMetadata.JobName)
                  .Build();
        }

        
        // public static async Task<bool> ReSchedular(TriggerKey key, string expressionTime)
        // {
        //     try
        //     {
                
        //         var trigger = await Scheduler.GetTrigger(new TriggerKey(key.Name, key.Group));
        //         var jobKey = new JobKey(key.Name, key.Group);
        //         if (!(await Scheduler.CheckExists(jobKey)))
        //         {
        //             var job = new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), "InitialJob", "0/10 * * * * ?", "DailyBaseLine");
        //             IJobDetail jobDetail = CreateJob(job);
        //             //Create trigger
        //             ITrigger createdTrigger = CreateTrigger(job);
        //             //Schedule job
        //             Scheduler.ScheduleJob(jobDetail, createdTrigger, new CancellationToken()).GetAwaiter();
        //             // Create Job
        //         }
        //         else
        //         {

        //             // await Scheduler.GetJobKeys()
        //             await Scheduler.RescheduleJob(trigger.Key, ReTriggered(trigger, expressionTime));
        //         }
        //         return true;

        //         // Scheduler = await _schedulerFactory.GetScheduler();
        //         // var trigger = await Scheduler.GetTrigger(new TriggerKey("BaseLine", "DailyBaseLine"));
        //         // await Scheduler.RescheduleJob(trigger.Key, ReTriggered(trigger, "0/1 * * * * ?"));
        //         // return true;
        //     }
        //     catch (System.Exception ex)
        //     {
        //         return false;
        //     }

        // }
    }
}