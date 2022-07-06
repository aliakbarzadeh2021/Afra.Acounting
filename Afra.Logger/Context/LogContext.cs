using Microsoft.EntityFrameworkCore;
using Afra.Logger.Models;

namespace Afra.Logger.Context
{
    public class LogContext : DbContext
    {
        public DbSet<CommandLog> CommandLogs { get; set; }

        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public LogContext(DbContextOptions<LogContext> options)
            : base(options)
        {
        }
    }
}
