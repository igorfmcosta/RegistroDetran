using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Core.Models;
using RegistroDetran.Core.Models.Options;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public class ConsultarSequencialContratoResquestService
        : RequestServiceBase<BodyConsulta, SoapEnvelopeRegistro>
    {
        public ConsultarSequencialContratoResquestService(HttpClient httpClient,
            DetranScOptions detranScSettings)
            : base(httpClient, detranScSettings) { }

        protected override string SoapAction =>
            "http://webservicesh.sc.gov.br/detran/RegistroContrato/ConsultarSequencialContrato";
        protected override string OperationName => "ConsultarSequencialContrato";
    }
}
