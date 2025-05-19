using FluentValidation;
using Microsoft.AspNetCore.Http.Json;
using RegistroDetran.API.Controllers;
using RegistroDetran.API.Extensions;
using RegistroDetran.Application.Validators;
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

// Custom service extensions
builder.Services
    .AddDatabase(builder.Configuration)
    .AddRepositories()
    .AddServices()
    .AddJwtAuthentication(builder.Configuration);

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