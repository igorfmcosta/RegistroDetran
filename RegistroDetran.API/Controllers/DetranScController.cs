using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RegistroDetran.API.Extensions;
using RegistroDetran.Application.DTOs;
using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Application.Services.Interfaces;


namespace RegistroDetran.API.Controllers
{
    public static class DetranScController
    {
        public static void MapDetranScEndpoints(this WebApplication app)
        {
            app.MapPost("/api/detran/sc/teste", (
                [FromBody] TesteDTO request) =>
            {
                return Results.Ok(request);
            })
            .WithName("Teste")
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/api/detran/sc/registrar_contrato", async (
                CancellationToken token,
                [FromBody] ContratoRequest request,
                [FromServices] IDetranScService soapService,
                IValidator<Contrato> validator) =>
                await request.Contrato.ValidateAndHandle(validator, async validDto => // Explicitly specify the generic type
                {
                    var response = await soapService.RegistrarContrato(token, request);
                    return Results.Ok(response);
                }))
            .WithName("RegistrarContrato")
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/api/detran/sc/consultar_contrato", async (
                CancellationToken token,
                [FromBody] ContratoRequest request,
                [FromServices] IDetranScService soapService) =>
            {
                var response = await soapService.ConsultarSequencialContrato(token, request);
                return Results.Ok(response);
            })
            .WithName("ConsultarSequencialContrato")
            .WithOpenApi()
            .AllowAnonymous();

            app.MapPost("/api/detran/sc/anexar_arquivo", async (
                CancellationToken token,
                [FromBody] ContratoRequest request,
                [FromServices] IDetranScService soapService) =>
            {
                var response = await soapService.AnexarAquivo(token, request);
                return Results.Ok(response);
            })
            .WithName("AnexarAquivo")
            .WithOpenApi()
            .AllowAnonymous();
        }
    }
}
