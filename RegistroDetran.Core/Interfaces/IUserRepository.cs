using RegistroDetran.Core.Entities;

namespace RegistroDetran.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
    }
}
