using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class sysdiagramsRepository : Repository<sysdiagrams> , IsysdiagramsRepository
    {
        public sysdiagramsRepository(DataContext context) : base(context)
        {
        }
    }
}
