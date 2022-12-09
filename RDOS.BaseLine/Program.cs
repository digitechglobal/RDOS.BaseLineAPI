using DocumentFormat.OpenXml.Wordprocessing;
using nProx.Helpers;
using nProx.Helpers.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
CoreDependency.InjectDependencies(builder.Services, builder);
var connectStrings = Environment.GetEnvironmentVariable("CONNECTION");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using (var scp = app.Services.CreateScope())
{
    SystemConfig.SwaggerName = "Ones Baseline API";
    CoreDependency.Configure(app, scp, connectStrings);
}
// Configure the HTTP request pipeline.



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
