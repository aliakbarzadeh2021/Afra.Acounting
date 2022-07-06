using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRqstItmRepository : Repository<TrsRqstItm> , ITrsRqstItmRepository
    {
        public TrsRqstItmRepository(DataContext context) : base(context)
        {
        }
    }
}
