using RegistroDetran.Core.Models;

namespace RegistroDetran.Core.Interfaces
{
    public interface ISoapService
    {
        Task<string> Send001Async(Contrato contrato);
        Task<string> Send002Async(Contrato contrato);
        Task<string> Send003Async(Contrato contrato);
    }
}
