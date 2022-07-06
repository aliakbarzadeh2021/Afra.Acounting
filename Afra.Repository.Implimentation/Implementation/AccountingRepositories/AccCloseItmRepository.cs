using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccCloseItmRepository : Repository<AccCloseItm> , IAccCloseItmRepository
    {
        public AccCloseItmRepository(DataContext context) : base(context)
        {
        }
    }
}
