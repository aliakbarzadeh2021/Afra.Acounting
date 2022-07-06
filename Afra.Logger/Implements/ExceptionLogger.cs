using System.Threading.Tasks;
using Afra.Logger.Context;
using Afra.Logger.Interfaces;
using Afra.Logger.Models;

namespace Afra.Logger.Implements
{
    public class ExceptionLogger : IExceptionLogger
    {
        private readonly LogContext _context;

        public ExceptionLogger(LogContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task LogAsync(ExceptionLog log)
        {
            _context.ExceptionLogs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
