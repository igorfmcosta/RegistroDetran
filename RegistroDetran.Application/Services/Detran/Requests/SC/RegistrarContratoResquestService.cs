using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Core.Models.Options;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public class RegistrarContratoResquestService
        : RequestServiceBase<BodyContrato>
    {
        public RegistrarContratoResquestService(HttpClient httpClient,
            DetranScOptions detranScSettings)
            : base(httpClient, detranScSettings) { }

        protected override string SoapAction =>
            "http://webservicesh.sc.gov.br/detran/RegistroContrato/RegistrarContrato";
        protected override string OperationName => "RegistrarContrato";
    }
}
