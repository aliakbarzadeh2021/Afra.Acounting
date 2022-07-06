using System.Threading.Tasks;
using Afra.Logger.Models;

namespace Afra.Logger.Interfaces
{
    public interface IExceptionLogger
    {
        Task LogAsync(ExceptionLog log);
    }
}
