using Microsoft.Extensions.Options;
using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Application.Services.Detran.Requests.SC;
using RegistroDetran.Application.Services.Interfaces;
using RegistroDetran.Core.Models.Options;

namespace RegistroDetran.Application.Services.Detran
{
    public class DetranScService(HttpClient httpClient, IOptions<DetranScOptions> detranScSettings): IDetranScService
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly DetranScOptions detranScSettings = detranScSettings.Value;

        public async Task<string> AnexarAquivo(CancellationToken cancellationToken, ContratoRequest contrato) 
            => await new AnexarAquivoResquestService(_httpClient, detranScSettings)
            .SendRequestAsync(cancellationToken, contrato);

        public async Task<IEnumerable<string>> RegistrarContrato(CancellationToken cancellationToken, ContratoRequest contratoRequest)
        {
            var response = new List<string>();

            foreach (var item in contratoRequest.Contrato.VeiculoContrato)
            {
                try
                {
                    var dados = (RegistrarContratoDTO)(contratoRequest, item);
                    var request = new BodyContrato(dados);
                    response.Add(await new RegistrarContratoResquestService(_httpClient, detranScSettings)
                    .SendRequestAsync(cancellationToken, request));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException?.Message);
                    var errorMessage = $"Erro ao registrar contrato para o veículo {item.Placa}.";
                    response.Add(errorMessage);
                    continue;
                }
            }
            return response;
        }

        public async Task<IEnumerable<string>> ConsultarSequencialContrato(CancellationToken cancellationToken, ContratoRequest contratoRequest)
        {
            var response = new List<string>();

            foreach (var item in contratoRequest.Contrato.VeiculoContrato)
            {
                try
                {
                    var request = (ConsultarSequencialContratoDTO)(contratoRequest, item);
                    response.Add(await new ConsultarSequencialContratoResquestService(_httpClient, detranScSettings)
                    .SendRequestAsync(cancellationToken, request));
                }
                catch (Exception)
                {
                    var errorMessage = $"Erro ao consultar contrato para o veículo {item.Placa}.";
                    response.Add(errorMessage);
                    continue;
                }
            }
            return response;
        }
    }
}
