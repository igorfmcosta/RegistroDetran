﻿using RegistroDetran.Core.Entities;

namespace RegistroDetran.Core.Interfaces
{
    public interface ILoggerService
    {
        Task<IEnumerable<LogEntry>> GetLogsAsync();
    }
}
