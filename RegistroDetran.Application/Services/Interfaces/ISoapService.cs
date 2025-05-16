using RegistroDetran.Application.DTOs.Contrato;

namespace RegistroDetran.Application.Services.Interfaces
{
    public interface ISoapService
    {
        Task<string> Send001Async(Contrato contrato);
        Task<string> Send002Async(Contrato contrato);
        Task<string> Send003Async(Contrato contrato);
    }
}
