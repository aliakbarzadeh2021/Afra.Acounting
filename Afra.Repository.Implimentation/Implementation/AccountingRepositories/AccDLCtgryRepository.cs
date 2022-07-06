using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccDLCtgryRepository : Repository<AccDLCtgry> , IAccDLCtgryRepository
    {
        public AccDLCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
