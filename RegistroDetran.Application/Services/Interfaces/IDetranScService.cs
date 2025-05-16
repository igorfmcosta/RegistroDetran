using RegistroDetran.Application.DTOs.Contrato;

namespace RegistroDetran.Application.Services.Interfaces
{
    public interface IDetranScService
    {
        Task<string> AnexarAquivo(ContratoRequest contrato);
        Task<IEnumerable<string>> RegistrarContrato(ContratoRequest contrato);
        Task<IEnumerable<string>> ConsultarSequencialContrato(ContratoRequest contrato);
    }
}
