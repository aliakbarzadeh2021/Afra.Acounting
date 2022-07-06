using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleAftSrvRepository : Repository<SleAftSrv> , ISleAftSrvRepository
    {
        public SleAftSrvRepository(DataContext context) : base(context)
        {
        }
    }
}
