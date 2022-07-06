using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmStatElmntMthdRepository : Repository<HrmStatElmntMthd> , IHrmStatElmntMthdRepository
    {
        public HrmStatElmntMthdRepository(DataContext context) : base(context)
        {
        }
    }
}
