
using Globo.TicketMng.Api.Middleware;
using Globo.TicketMng.Application;
using Globo.TicketMng.Insfratructure;
using Globo.TicketMng.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

builder.Services.AddPersistenceServices(configuration);
builder.Services.AddApplicationServices();
builder.Services.AddInsfratructureServices(configuration);
builder.Services.AddControllers();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
