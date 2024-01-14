using ecommerceAPI.API;
using ecommerceAPI.Persistance;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//health check
builder.Services
    .AddHealthChecks()
    .AddSqlServer(StaticConfigurations.ConnectionString);

ConfigureLogging.Configure();
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddPersistenceServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//health check
app.UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapHealthChecks("/health", new HealthCheckOptions
        {
            Predicate = _ => true,
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });
    });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
