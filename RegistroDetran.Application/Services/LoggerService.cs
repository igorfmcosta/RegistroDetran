using RegistroDetran.Core.Entities;
using RegistroDetran.Core.Interfaces;

namespace RegistroDetran.Application.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILogRepository _logRepository;
        public LoggerService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }
        public async Task<IEnumerable<LogEntry>> GetLogsAsync() =>
            await _logRepository.GetLogsAsync();
    }
}
