using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoBaseTypesRepository : Repository<OtoBaseTypes> , IOtoBaseTypesRepository
    {
        public OtoBaseTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
