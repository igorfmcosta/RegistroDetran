using RegistroDetran.Application.DTOs.Contrato;

namespace RegistroDetran.Application.Services.Interfaces
{
    public interface IDetranScService
    {
        Task<IEnumerable<string>> AnexarAquivo(CancellationToken cancellationToken, Contrato contrato);
        Task<IEnumerable<string>> RegistrarContrato(CancellationToken cancellationToken, Contrato contrato);
        Task<IEnumerable<string>> ConsultarSequencialContrato(CancellationToken cancellationToken, Contrato contrato);
    }
}
