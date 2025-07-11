using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Core.Models.Options;
using System.Text;
using System.Xml.Serialization;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public abstract class RequestServiceBase<TRequest> where TRequest : class
    {
        protected readonly HttpClient _httpClient;
        protected readonly DetranScOptions _detranScSettings;

        public RequestServiceBase(HttpClient httpClient, DetranScOptions detranScSettings)
        {
            _detranScSettings = detranScSettings;
            _httpClient = httpClient;
        }
        protected abstract string SoapAction { get; }
        protected abstract string OperationName { get; }

        public async Task<string> SendRequestAsync(CancellationToken cancellationToken, TRequest request)
        {
            var response = await ExecuteSoapRequestAsync(cancellationToken, request);
            return response;
        }

        protected async Task<string> ExecuteSoapRequestAsync(CancellationToken cancellationToken, TRequest request)
        {
            var envelope = CreateEnvelopeObject(request);

            var xmlEnvelope = BuildxmlEnvelope(envelope);
            var requestContent = new StringContent(xmlEnvelope, Encoding.UTF8, "application/soap+xml");

            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, ""))
            {
                requestMessage.Content = requestContent;
                requestMessage.Headers.Add("SOAPAction", SoapAction);
                requestMessage.Headers.Add("Accept", "application/soap+xml");

                var response = await _httpClient.SendAsync(requestMessage, cancellationToken);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }

        private string BuildxmlEnvelope(Envelope<TRequest> envelope)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("soap", Envelope<TRequest>.SoapNs);
            ns.Add("reg", Envelope<TRequest>.RegNs);
            var serializer = new XmlSerializer(typeof(Envelope<TRequest>));
            try
            {
                using (var writer = new StringWriter())
                {
                    serializer.Serialize(writer, envelope, ns);
                    return writer.ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private Envelope<TRequest> CreateEnvelopeObject(TRequest request)
        {
            return new Envelope<TRequest>
            {
                Header = new Header
                {
                    Credenciais = new Credenciais
                    {
                        Usuario = _detranScSettings.Usuario,
                        Senha = _detranScSettings.Senha
                    }
                },
                Body = request
            };
        }
    }
}
