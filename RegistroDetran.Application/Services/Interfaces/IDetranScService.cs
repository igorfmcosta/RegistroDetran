using RegistroDetran.Application.DTOs.Contrato;
using RegistroDetran.Application.DTOs.Detran.SC;

namespace RegistroDetran.Application.Services.Interfaces
{
    public interface IDetranScService
    {
        Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> AnexarAquivo(CancellationToken cancellationToken, Contrato contrato);
        Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> RegistrarContrato(CancellationToken cancellationToken, Contrato contrato);
        Task<IEnumerable<ResultDTO<RegistrarContratoResult>>> ConsultarSequencialContrato(CancellationToken cancellationToken, Contrato contrato);
    }
}
