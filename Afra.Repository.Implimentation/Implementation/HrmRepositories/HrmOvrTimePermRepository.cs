using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmOvrTimePermRepository : Repository<HrmOvrTimePerm> , IHrmOvrTimePermRepository
    {
        public HrmOvrTimePermRepository(DataContext context) : base(context)
        {
        }
    }
}
