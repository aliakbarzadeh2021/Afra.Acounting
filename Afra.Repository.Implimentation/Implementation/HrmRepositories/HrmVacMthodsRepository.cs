using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmVacMthodsRepository : Repository<HrmVacMthods> , IHrmVacMthodsRepository
    {
        public HrmVacMthodsRepository(DataContext context) : base(context)
        {
        }
    }
}
