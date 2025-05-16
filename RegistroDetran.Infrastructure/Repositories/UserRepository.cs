using Microsoft.EntityFrameworkCore;
using RegistroDetran.Core.Entities;
using RegistroDetran.Core.Interfaces;
using RegistroDetran.Infrastructure.Data;

namespace RegistroDetran.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
