using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsPayChqItmRepository : Repository<TrsPayChqItm> , ITrsPayChqItmRepository
    {
        public TrsPayChqItmRepository(DataContext context) : base(context)
        {
        }
    }
}
