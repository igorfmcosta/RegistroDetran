using Microsoft.AspNetCore.Mvc;
using RegistroDetran.Core.Interfaces;


namespace RegistroDetran.API.Controllers
{
    public static class AuthController
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {
            app.MapPost("/api/auth/login", async (
                [FromBody] LoginRequest request,
                [FromServices] IAuthService authService) =>
            {
                var token = await authService.AuthenticateAsync(request.Username, request.Password);
                return Results.Ok(new { Token = token });
            })
            .WithName("Login")
            .WithOpenApi();
        }
    }

    public record LoginRequest(string Username, string Password);
}
