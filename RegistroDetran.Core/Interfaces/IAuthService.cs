using RegistroDetran.Core.Entities;

namespace RegistroDetran.Core.Interfaces
{
    public interface IAuthService
    {
        Task<string> AuthenticateAsync(string username, string password);
    }
}
