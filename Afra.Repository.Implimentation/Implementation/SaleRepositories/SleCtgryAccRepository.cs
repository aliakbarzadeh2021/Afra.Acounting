using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCtgryAccRepository : Repository<SleCtgryAcc> , ISleCtgryAccRepository
    {
        public SleCtgryAccRepository(DataContext context) : base(context)
        {
        }
    }
}
