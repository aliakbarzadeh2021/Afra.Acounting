using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRcvChqItmRepository : Repository<TrsRcvChqItm> , ITrsRcvChqItmRepository
    {
        public TrsRcvChqItmRepository(DataContext context) : base(context)
        {
        }
    }
}
