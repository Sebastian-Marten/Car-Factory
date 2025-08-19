using CarFactoryApi;
using CarFactoryApi.BodyTypes;
using CarFactoryApi.Engines;
using CarFactoryApi.Interfaces;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IEngine, FourCylinder>();
builder.Services.AddTransient<IBodyType, Sedan>();
builder.Services.AddTransient<CarFactory>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.UseHttpsRedirection();
app.Run();