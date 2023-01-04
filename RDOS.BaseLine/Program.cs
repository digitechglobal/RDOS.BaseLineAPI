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
using nProx.Helpers.JWT;

var builder = WebApplication.CreateBuilder(args);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Add services to the container.
builder.Services.AddControllers();
CoreDependency.InjectDependencies(builder.Services, builder);
builder.Services.AddScoped<DbContext, RDOSContext>();
builder.Services.AddScoped<IBaselineSettingService, BaselineSettingService>();
builder.Services.AddScoped<IBaselineProcessService, BaselineProcessService>();
builder.Services.AddScoped<IPhattvBLProcessService, PhattvBLProcessService>();
builder.Services.AddScoped<IMySchedular, MySchedular>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IConfirmPerformanceService, ConfirmPerformanceService>();
builder.Services.AddScoped<IInitialService, InitialService>();

var connectStrings = Environment.GetEnvironmentVariable("CONNECTION");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Get all url from table service
builder.Services.AddScoped<ISystemUrlService, SystemUrlService>();
SystemUrlService systemUrlService = new();
SystemUrl = systemUrlService.GetAllSystemUrl().Result.Items.ToList();



builder.Services.AddTransient<IJobFactory, MyJobFactory>();
builder.Services.AddTransient<ISchedulerFactory, StdSchedulerFactory>();
#region Adding JobType
builder.Services.AddTransient<NotificationJob>();
builder.Services.AddTransient<LoggerJob>();
builder.Services.AddTransient<InitialJob>();
builder.Services.AddTransient<PendingDataProcessJob>();
builder.Services.AddTransient<BaseLineProcessJob>();
#endregion

List<JobMetadata> jobMetadatas = new List<JobMetadata>();
//Lấy thời gian hiện tại 
//ra được expression +  1ps 
// jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "00 07 21 ? * *", "DailyBaseLine"));
jobMetadatas.Add(new JobMetadata(Guid.NewGuid(), typeof(InitialJob), "InitialJob", "1 * * * * ?", "DailyBaseLine"));
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
