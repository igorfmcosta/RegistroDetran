using RegistroDetran.Application.DTOs.Contrato;

namespace RegistroDetran.Application.Services.Interfaces
{
    public interface IDetranScService
    {
        Task<string> AnexarAquivo(CancellationToken cancellationToken, ContratoRequest contrato);
        Task<IEnumerable<string>> RegistrarContrato(CancellationToken cancellationToken, ContratoRequest contrato);
        Task<IEnumerable<string>> ConsultarSequencialContrato(CancellationToken cancellationToken, ContratoRequest contrato);
    }
}
