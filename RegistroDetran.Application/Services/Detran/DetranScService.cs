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

        public async Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> AnexarAquivo(CancellationToken cancellationToken, Contrato contrato)
        {
            var response = new List<ResultDTO<RegistrarContratoResult>>();

            foreach (var item in contrato.VeiculoContrato)
            {
                var result = new ResultDTO<RegistrarContratoResult>();
                result.Placa = item.Placa;

                try
                {
                    var dados = (AnexarArquvioContratoDto)(contrato, item);
                    var request = new BodyAnexo(dados);
                    var xmlResult = await new AnexarAquivoResquestService(_httpClient, detranScSettings)
                        .SendRequestAsync(cancellationToken, request);
                    result.Result = xmlResult.Body.RegistrarContratoResponse.RegistrarContratoResult;

                    response.Add(result);
                }
                catch (Exception)
                {
                    var errorMessage = $"Erro ao consultar contrato para o veículo {item.Placa}.";
                    result.Erro = errorMessage;
                    response.Add(result);
                    continue;
                }
            }
            return response;
        }

        public async Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> RegistrarContrato(CancellationToken cancellationToken, Contrato contratoRequest)
        {
            var response = new List<ResultDTO<RegistrarContratoResult>>();
            
            foreach (var item in contratoRequest.VeiculoContrato)
            {
                var result = new ResultDTO<RegistrarContratoResult>();
                result.Placa = item.Placa;

                try
                {
                    var dados = (RegistrarContratoDTO)(contratoRequest, item);
                    var request = new BodyContrato(dados);
                    var xmlResult = await new RegistrarContratoResquestService(_httpClient, detranScSettings)
                        .SendRequestAsync(cancellationToken, request);

                    result.Result = xmlResult.Body.RegistrarContratoResponse.RegistrarContratoResult;
                    
                    response.Add(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException?.Message);
                    var errorMessage = $"Erro ao registrar contrato.";
                    result.Erro = errorMessage;
                    response.Add(result);
                    continue;
                }
            }
            return response;
        }

        public async Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> ConsultarSequencialContrato(CancellationToken cancellationToken, Contrato contratoRequest)
        {
            var response = new List<ResultDTO<RegistrarContratoResult>> ();

            foreach (var item in contratoRequest.VeiculoContrato)
            {
                var result = new ResultDTO<RegistrarContratoResult>();
                result.Placa = item.Placa;

                try
                {
                    var dados = (ConsultarSequencialContratoDTO)(contratoRequest, item);
                    var request = new BodyConsulta(dados);
                    var xmlResult = await new ConsultarSequencialContratoResquestService(_httpClient, detranScSettings)
                    .SendRequestAsync(cancellationToken, request);
                    result.Result = xmlResult.Body.RegistrarContratoResponse.RegistrarContratoResult;
                    response.Add(result);
                }
                catch (Exception)
                {
                    var errorMessage = $"Erro ao consultar contrato para o veículo {item.Placa}.";
                    result.Erro = errorMessage;
                    response.Add(result);
                    continue;
                }
            }
            return response;
        }
    }
}
