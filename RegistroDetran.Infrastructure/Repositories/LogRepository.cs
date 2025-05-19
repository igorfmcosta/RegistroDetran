using Microsoft.EntityFrameworkCore;
using RegistroDetran.Core.Entities;
using RegistroDetran.Core.Interfaces;
using RegistroDetran.Infrastructure.Data;

namespace RegistroDetran.Infrastructure.Repositories
{
    public class LogRepository: ILogRepository
    {
        private readonly AppDbContext _context;
        public LogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LogEntry>> GetLogsAsync()
        {
            return await _context.Logs.ToListAsync();
        }
    }
}
