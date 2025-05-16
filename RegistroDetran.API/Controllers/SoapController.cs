using Microsoft.AspNetCore.Mvc;
using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Application.Services.Interfaces;

namespace RegistroDetran.API.Controllers
{
    public static class SoapController
    {
        public static void MapSoapEndpoints(this WebApplication app)
        {
            app.MapPost("/api/detran/rj/send001", async (
            [FromBody] Contrato request,
            [FromServices] ISoapService soapService) =>
            {
                var response = await soapService.Send001Async(request);
                return Results.Ok(response);
            })
            .WithName("Send001")
            .WithOpenApi()
            .RequireAuthorization();

            app.MapPost("/api/detran/rj/send002", async (
                [FromBody] Contrato request,
                [FromServices] ISoapService soapService) =>
            {
                var response = await soapService.Send002Async(request);
                return Results.Ok(response);
            })
            .WithName("Send002")
            .WithOpenApi()
            .RequireAuthorization();

            app.MapPost("/api/detran/rj/send003", async (
                [FromBody] Contrato request,
                [FromServices] ISoapService soapService) =>
            {
                var response = await soapService.Send003Async(request);
                return Results.Ok(response);
            })
            .WithName("send003")
            .WithOpenApi()
            .RequireAuthorization();
        }
    }
}
