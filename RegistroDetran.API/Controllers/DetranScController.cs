using Microsoft.AspNetCore.Mvc;
using RegistroDetran.Core.Interfaces;
using RegistroDetran.Core.Models;

namespace RegistroDetran.API.Controllers
{
    public static class DetranScController
    {
        public static void MapDetranScEndpoints(this WebApplication app)
        {
            app.MapPost("/api/detran/sc/registrar_contrato", async (
            [FromBody] ContratoRequest request,
            [FromServices] IDetranScService soapService) =>
            {
                var response = await soapService.RegistrarContrato(request);
                return Results.Ok(response);
            })
            .WithName("RegistrarContrato")
            .WithOpenApi()
            .RequireAuthorization();

            app.MapPost("/api/detran/sc/consultar_contrato", async (
                [FromBody] ContratoRequest request,
                [FromServices] IDetranScService soapService) =>
            {
                var response = await soapService.ConsultarSequencialContrato(request);
                return Results.Ok(response);
            })
            .WithName("ConsultarSequencialContrato")
            .WithOpenApi()
            .RequireAuthorization();

            app.MapPost("/api/detran/sc/anexar_arquivo", async (
                [FromBody] ContratoRequest request,
                [FromServices] IDetranScService soapService) =>
            {
                var response = await soapService.AnexarAquivo(request);
                return Results.Ok(response);
            })
            .WithName("AnexarAquivo")
            .WithOpenApi()
            .RequireAuthorization();
        }
    }
}
