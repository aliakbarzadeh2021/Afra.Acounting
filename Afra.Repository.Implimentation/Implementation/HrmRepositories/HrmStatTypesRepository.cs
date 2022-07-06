using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmStatTypesRepository : Repository<HrmStatTypes> , IHrmStatTypesRepository
    {
        public HrmStatTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
