using DemoCronjob.JobFactory;
using DemoCronjob.Jobs;
using DemoCronjob.Models;
using DemoCronjob.Schedular;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers;
using nProx.Helpers.Helpers;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using RDOS.BaseLine.RDOSInfratructure;
using RDOS.BaseLine.Service;
using RDOS.BaseLine.Service.Interface;
using SysAdmin.Web.Services.SystemUrl;
using static SysAdmin.Models.StaticValue.CommonData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
CoreDependency.InjectDependencies(builder.Services, builder);
builder.Services.AddTransient<DbContext, RDOSContext>();
builder.Services.AddScoped<IBaselineSettingService, BaselineSettingService>();
builder.Services.AddScoped<IBaselineProcessService, BaselineProcessService>();
builder.Services.AddScoped<IPhattvBLProcessService, PhattvBLProcessService>();
var connectStrings = Environment.GetEnvironmentVariable("CONNECTION");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Get all url from table service
builder.Services.AddScoped<ISystemUrlService, SystemUrlService>();
SystemUrlService systemUrlService = new();
SystemUrl = systemUrlService.GetAllSystemUrl().Result.Items.ToList();

builder.Services.AddSingleton<IJobFactory, MyJobFactory>();
builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
#region Adding JobType
builder.Services.AddSingleton<NotificationJob>();
builder.Services.AddSingleton<LoggerJob>();
#endregion

List<JobMetadata> jobMetadatas = new List<JobMetadata>();
jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), "BaseLine", "0/5 * * * * ?", "DailyBaseLine"));
//jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(LoggerJob), "Log Job", "0/5 * * * * ?"));

builder.Services.AddSingleton(jobMetadatas);

builder.Services.AddHostedService<MySchedular>();




var app = builder.Build();
using (var scp = app.Services.CreateScope())
{
    SystemConfig.JWT_KEY = "THIS-IS-USED TO SIGN AND VERIFY___JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING";
    SystemConfig.SwaggerName = "Ones Baseline API";
    CoreDependency.Configure(app, scp, connectStrings);
}
// Configure the HTTP request pipeline.



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
