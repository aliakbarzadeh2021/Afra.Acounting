using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCtgryRepository : Repository<SleCtgry> , ISleCtgryRepository
    {
        public SleCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
