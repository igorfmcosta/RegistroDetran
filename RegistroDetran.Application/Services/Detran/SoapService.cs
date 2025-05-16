using Microsoft.Extensions.Options;
using RegistroDetran.Application.Services.Detran.Requests.RJ;
using RegistroDetran.Core.Interfaces;
using RegistroDetran.Core.Models;
using RegistroDetran.Core.Models.Options;
using System.Net.Http.Headers;
using System.Text;

namespace RegistroDetran.Application.Services.Detran
{
    public class SoapService(HttpClient httpClient, IOptions<SoapServiceOptions> soapSettings) : ISoapService
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly SoapServiceOptions _soapSettings = soapSettings.Value;

        public async Task<string> SendSoapRequestAsync(SoapRequestBase request, Contrato contrato)
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("text/xml"));

            var soapEnvelope = request.CreateEnvelope(contrato, _soapSettings);

            var content = new StringContent(soapEnvelope.ToString(), Encoding.UTF8, "text/xml");
            var response = await _httpClient.PostAsync(_soapSettings.Endpoint, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Send001Async(Contrato contrato)
        {
            var request = new SoapRequest001();
            return await SendSoapRequestAsync(request, contrato);
        }

        public async Task<string> Send002Async(Contrato contrato)
        {
            var request = new SoapRequest002();
            return await SendSoapRequestAsync(request, contrato);
        }

        public async Task<string> Send003Async(Contrato contrato)
        {
            var request = new SoapRequest003();
            return await SendSoapRequestAsync(request, contrato);
        }
    }
}
