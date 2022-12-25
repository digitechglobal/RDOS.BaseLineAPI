using RDOS.BaseLine.JobFactory;
using RDOS.BaseLine.Jobs;
using RDOS.BaseLine.Models;
using RDOS.BaseLine.Schedular;
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
using RDOS.BaseLine.Services.Interface;
using RDOS.BaseLine.Services;

var builder = WebApplication.CreateBuilder(args);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Add services to the container.
builder.Services.AddControllers();
CoreDependency.InjectDependencies(builder.Services, builder);
builder.Services.AddTransient<DbContext, RDOSContext>();
builder.Services.AddTransient<IBaselineSettingService, BaselineSettingService>();
builder.Services.AddTransient<IBaselineProcessService, BaselineProcessService>();
builder.Services.AddTransient<IPhattvBLProcessService, PhattvBLProcessService>();
builder.Services.AddTransient<IMySchedular, MySchedular>();
builder.Services.AddTransient<IClientService, ClientService>();

var connectStrings = Environment.GetEnvironmentVariable("CONNECTION");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Get all url from table service
builder.Services.AddTransient<ISystemUrlService, SystemUrlService>();
SystemUrlService systemUrlService = new();
SystemUrl = systemUrlService.GetAllSystemUrl().Result.Items.ToList();

builder.Services.AddSingleton<IJobFactory, MyJobFactory>();
builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
#region Adding JobType
builder.Services.AddSingleton<NotificationJob>();
builder.Services.AddSingleton<LoggerJob>();
builder.Services.AddSingleton<InitialJob>();
builder.Services.AddSingleton<PendingDataProcessJob>();
#endregion

List<JobMetadata> jobMetadatas = new List<JobMetadata>();
//Lấy thời gian hiện tại 
//ra được expression +  1ps 
jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "00 07 21 ? * *", "DailyBaseLine"));
// jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(NotificationJob), "BLPendingProcess", "0/5 * * * * ?", "DailyBaseLine"));
// jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(LoggerJob), "BLProcess", "0/5 * * * * ?", "DailyBaseLine"));

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
