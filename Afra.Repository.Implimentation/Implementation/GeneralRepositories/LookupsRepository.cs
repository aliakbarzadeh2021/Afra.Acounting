using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class LookupsRepository : Repository<Lookups> , ILookupsRepository
    {
        public LookupsRepository(DataContext context) : base(context)
        {
        }
    }
}
