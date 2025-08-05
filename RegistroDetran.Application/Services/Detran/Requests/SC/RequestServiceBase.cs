using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Core.Models.Options;
using System.Text;
using System.Xml.Serialization;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public abstract class RequestServiceBase<TRequest, TReturn> where TRequest : class
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

        public async Task<TReturn> SendRequestAsync(CancellationToken cancellationToken, TRequest request)
        {
            var response = await ExecuteSoapRequestAsync(cancellationToken, request);
            return response;
        }

        protected async Task<TReturn> ExecuteSoapRequestAsync(CancellationToken cancellationToken, TRequest request)
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

                var strReturn = await response.Content.ReadAsStringAsync();

                return DeserializeXml(strReturn);
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

        public static TReturn DeserializeXml(string xmlContent)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(TReturn));
                using var stringReader = new StringReader(xmlContent);
                return (TReturn)serializer.Deserialize(stringReader);
            }
            catch (Exception ex)
            {
                // Log do erro ou tratamento apropriado
                throw new InvalidOperationException($"Erro ao deserializar XML: {ex.Message}", ex);
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
