using Microsoft.Extensions.Options;
using RegistroDetran.Core.Entities;
using RegistroDetran.Core.Models.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetran.Infrastructure.Data
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }

    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly AppDbContext _context;
        private readonly AppUserOptions _credentials;

        public DatabaseSeeder(AppDbContext context, IOptions<AppUserOptions> credentials)
        {
            _context = context;
            _credentials = credentials.Value;
        }

        public async Task SeedAsync()
        {
            if (!_context.Users.Any())
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Username = _credentials.Username,
                    Password = _credentials.Password // In production, hash this password
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
