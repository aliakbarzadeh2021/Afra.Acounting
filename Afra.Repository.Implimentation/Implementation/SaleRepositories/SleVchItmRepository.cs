using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleVchItmRepository : Repository<SleVchItm> , ISleVchItmRepository
    {
        public SleVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
