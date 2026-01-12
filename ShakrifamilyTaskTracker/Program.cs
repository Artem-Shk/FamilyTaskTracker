using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.CreateTasks;
using FamilyTaskTracker.ShakrifamilyTaskTracker.Features.Tasks.GetTasksById;

using FamilyTaskTracker.ShakrifamilyTaskTracker.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/", () => "API is running");

app.Run();