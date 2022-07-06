using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleDebCreItmRepository : Repository<SleDebCreItm> , ISleDebCreItmRepository
    {
        public SleDebCreItmRepository(DataContext context) : base(context)
        {
        }
    }
}
