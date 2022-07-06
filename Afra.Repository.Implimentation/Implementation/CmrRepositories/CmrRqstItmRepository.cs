using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrRqstItmRepository : Repository<CmrRqstItm> , ICmrRqstItmRepository
    {
        public CmrRqstItmRepository(DataContext context) : base(context)
        {
        }
    }
}
