using Microsoft.AspNetCore.Http.Json;
using RegistroDetran.API.Controllers;
using RegistroDetran.API.Extensions;
using RegistroDetran.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.Converters.Add(new CustomDateTimeConverter());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Custom service extensions
builder.Services
    .AddDatabase(builder.Configuration)
    .AddRepositories()
    .AddServices()
    .AddJwtAuthentication(builder.Configuration);

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
//app.UseMiddlewares();

// Map endpoints
app.MapAuthEndpoints();
app.MapSoapEndpoints();
app.MapDetranScEndpoints();

app.Run();