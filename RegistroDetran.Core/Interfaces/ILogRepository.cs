using RegistroDetran.Core.Entities;

namespace RegistroDetran.Core.Interfaces
{
    public interface ILogRepository
    {
        Task<IEnumerable<LogEntry>> GetLogsAsync();
    }
}
