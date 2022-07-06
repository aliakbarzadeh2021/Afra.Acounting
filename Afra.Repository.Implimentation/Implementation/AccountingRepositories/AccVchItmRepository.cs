using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccVchItmRepository : Repository<AccVchItm> , IAccVchItmRepository
    {
        public AccVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
