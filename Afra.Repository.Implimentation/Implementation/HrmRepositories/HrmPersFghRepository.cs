using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersFghRepository : Repository<HrmPersFgh> , IHrmPersFghRepository
    {
        public HrmPersFghRepository(DataContext context) : base(context)
        {
        }
    }
}
