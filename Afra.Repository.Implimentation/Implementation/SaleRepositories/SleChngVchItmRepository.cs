using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleChngVchItmRepository : Repository<SleChngVchItm> , ISleChngVchItmRepository
    {
        public SleChngVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
