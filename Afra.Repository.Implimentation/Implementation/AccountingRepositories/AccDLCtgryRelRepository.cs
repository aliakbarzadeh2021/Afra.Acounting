using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccDLCtgryRelRepository : Repository<AccDLCtgryRel> , IAccDLCtgryRelRepository
    {
        public AccDLCtgryRelRepository(DataContext context) : base(context)
        {
        }
    }
}
