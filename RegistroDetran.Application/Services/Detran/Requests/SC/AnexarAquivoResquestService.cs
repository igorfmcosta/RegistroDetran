using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Application.DTOs.Detran.SC;
using RegistroDetran.Core.Models.Options;

namespace RegistroDetran.Application.Services.Detran.Requests.SC
{
    public class AnexarAquivoResquestService
        : RequestServiceBase<BodyAnexo>
    {
        public AnexarAquivoResquestService(HttpClient httpClient,
            DetranScOptions detranScSettings)
            : base(httpClient, detranScSettings) { }

        protected override string SoapAction =>
            "http://webservicesh.sc.gov.br/detran/RegistroContrato/AnexarArquivo";
        protected override string OperationName => "AnexarArquivo";
    }
}
