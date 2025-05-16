using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Polly;
using Polly.Extensions.Http;
using RegistroDetran.Application.Services;
using RegistroDetran.Application.Services.Detran;
using RegistroDetran.Application.Services.Interfaces;
using RegistroDetran.Core.Interfaces;
using RegistroDetran.Core.Models.Options;
using RegistroDetran.Infrastructure.Data;
using RegistroDetran.Infrastructure.Middleware;
using RegistroDetran.Infrastructure.Protection;
using RegistroDetran.Infrastructure.Repositories;
using System.Text;

namespace RegistroDetran.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("CleanArchitectureDb"));

            services.AddScoped<IDatabaseSeeder, DatabaseSeeder>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddHttpClient<IDetranScService, DetranScService>()
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());
            services.AddHttpClient<ISoapService, SoapService>()
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }

        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataProtection()
                .SetApplicationName("RegistroDetran");
            services.AddSingleton<SecretProtector>();

            // Bind and protect configuration
            services.Configure<JwtOptions>(config =>
            {
                var protector = services.BuildServiceProvider().GetRequiredService<SecretProtector>();
                var jwtSettings = configuration.GetSection("Jwt").Get<JwtOptions>();
                config.Secret = protector.Unprotect(jwtSettings!.Secret);
            });

            services.Configure<AppUserOptions>(config =>
            {
                var protector = services.BuildServiceProvider().GetRequiredService<SecretProtector>();
                var credentials = configuration.GetSection("AppUser").Get<AppUserOptions>();
                config.Username = protector.Unprotect(credentials!.Username);
                config.Password = protector.Unprotect(credentials.Password);
            });

            services.Configure<SoapServiceOptions>(configuration.GetSection("SoapService"));
            services.Configure<DetranScOptions>(configuration.GetSection("DetranSC"));

            var serviceProvider = services.BuildServiceProvider();
            var jwtSettings = serviceProvider.GetRequiredService<IOptions<JwtOptions>>().Value;
            var key = Encoding.ASCII.GetBytes(jwtSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }

        public static IServiceCollection AddMiddleware(this IServiceCollection services)
        {
            services.AddTransient<ExceptionHandlingMiddleware>();
            return services;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(3, retryAttempt =>
                    TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }

        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return Policy<HttpResponseMessage>
                .Handle<HttpRequestException>()
                .CircuitBreakerAsync(5, TimeSpan.FromSeconds(60));
        }

    }
}
