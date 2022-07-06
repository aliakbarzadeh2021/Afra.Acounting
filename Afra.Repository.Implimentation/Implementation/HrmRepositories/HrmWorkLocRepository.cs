using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmWorkLocRepository : Repository<HrmWorkLoc> , IHrmWorkLocRepository
    {
        public HrmWorkLocRepository(DataContext context) : base(context)
        {
        }
    }
}
