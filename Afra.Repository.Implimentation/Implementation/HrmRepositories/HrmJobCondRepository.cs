using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmJobCondRepository : Repository<HrmJobCond> , IHrmJobCondRepository
    {
        public HrmJobCondRepository(DataContext context) : base(context)
        {
        }
    }
}
