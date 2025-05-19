using FluentValidation;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RegistroDetran.API.Controllers;
using RegistroDetran.API.Extensions;
using RegistroDetran.Application.Validators;
using RegistroDetran.Core.Models.Options;
using RegistroDetran.Infrastructure.Data;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new CustomDateTimeConverter());
    options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Bind and protect configuration
builder.Services.Configure<JwtOptions>(config =>
{
    var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtOptions>();
    config.Secret = jwtSettings!.Secret;
});

builder.Services.Configure<AppUserOptions>(config =>
{
    var credentials = builder.Configuration.GetSection("AppUser").Get<AppUserOptions>();
    config.Username = credentials!.Username;
    config.Password = credentials.Password;
});

builder.Services.Configure<SoapServiceOptions>(builder.Configuration.GetSection("SoapService"));
builder.Services.Configure<DetranScOptions>(builder.Configuration.GetSection("DetranSC"));

// Custom service extensions
builder.Services
    .AddDatabase()
    .AddRepositories()
    .AddServices(builder.Configuration)
    .AddJwtAuthentication();

builder.Services.AddValidatorsFromAssemblyContaining<ContratoValidator>();

var app = builder.Build();

// Seed database
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<IDatabaseSeeder>();
    await seeder.SeedAsync();
}

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// Exception handling middleware
app.UseMiddlewares();

// Map endpoints
app.MapAuthEndpoints();
app.MapSoapEndpoints();
app.MapDetranScEndpoints();
app.MapLogEndpoints();

app.Run();