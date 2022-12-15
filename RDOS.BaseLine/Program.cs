using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using nProx.Helpers;
using nProx.Helpers.Helpers;
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
builder.Services.AddScoped<IPhattvBLProcessService, IPhattvBLProcessService>();
var connectStrings = Environment.GetEnvironmentVariable("CONNECTION");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Get all url from table service
builder.Services.AddScoped<ISystemUrlService, SystemUrlService>();
SystemUrlService systemUrlService = new();
SystemUrl = systemUrlService.GetAllSystemUrl().Result.Items.ToList();



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
