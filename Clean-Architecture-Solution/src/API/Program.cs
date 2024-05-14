using System.Reflection;
using Infrastructure;
using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Application.Abstractions.Repositories;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);




ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddInfrastructure()
    .AddApplication();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

builder.Services.AddScoped<IGameRepository, GameRepository>();

var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<GameDbContext>();

var app = builder.Build();

app.UseCors(builder =>
builder.WithOrigins("*")
.AllowAnyMethod()
.AllowAnyHeader());

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

//app.UseHttpsRedirection();
app.UseAuthentication();

app.MapControllers().AllowAnonymous();

app.Run();
