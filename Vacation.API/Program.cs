using Microsoft.AspNetCore.Mvc;
using Vacation.API.Repositories.InMemory;
using Vacation.API.Repositories.Repositories;
using Vacation.API.Services;
using Vacation.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//gs: add versions to API
builder.Services.AddApiVersioning(option =>
{
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.DefaultApiVersion = new ApiVersion(1, 0);
    option.ReportApiVersions = true;
});
builder.Services.AddVersionedApiExplorer(option =>
{
    option.GroupNameFormat = "'v'VVV";
    option.SubstituteApiVersionInUrl = true;
});

// gs: For injecting dependencies
builder.Services.AddSingleton<INonWorkingDaysRepository, InMemoryNonWorkingDaysRepository>();
builder.Services.AddSingleton<IWorkingDayService, WorkingDayService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();