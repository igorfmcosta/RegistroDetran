using RegistroDetran.Core.Models.Options;
using System.Text;
using System.Xml.Serialization;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public abstract class RequestServiceBase<TRequest>
    {
        protected readonly HttpClient _httpClient;
        protected readonly DetranScOptions _detranScSettings;

        public RequestServiceBase(HttpClient httpClient, DetranScOptions detranScSettings)
        {
            _detranScSettings = detranScSettings;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_detranScSettings.BaseUrl);
        }
        protected abstract string SoapAction { get; }
        protected abstract string OperationName { get; }

        public async Task<string> SendRequestAsync(TRequest request)
        {
            var response = await ExecuteSoapRequestAsync(request);
            return response;
        }

        protected async Task<string> ExecuteSoapRequestAsync(TRequest request)
        {
            var soapEnvelope = BuildSoapEnvelope(request);
            var requestContent = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");

            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, ""))
            {
                requestMessage.Content = requestContent;
                requestMessage.Headers.Add("SOAPAction", SoapAction);

                var response = await _httpClient.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }

        private string BuildSoapEnvelope(TRequest request)
        {
            var serializer = new XmlSerializer(typeof(TRequest));
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, request);
                var requestBody = writer.ToString();

                return $@"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
                               xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" 
                               xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                    <soap:Header>
                        <Credenciais xmlns=""http://webservicesh.sc.gov.br/detran/RegistroContrato"">
                          <Usuario>{_detranScSettings.Usuario}</Usuario>
                          <Senha>{_detranScSettings.Senha}</Senha>
                        </Credenciais>
                      </soap:Header>
                    <soap:Body>
                        <{OperationName} xmlns=""http://webservicesh.sc.gov.br/detran/RegistroContrato"">
                            {requestBody}
                        </{OperationName}>
                    </soap:Body>
                </soap:Envelope>";
            }
        }
    }
}
