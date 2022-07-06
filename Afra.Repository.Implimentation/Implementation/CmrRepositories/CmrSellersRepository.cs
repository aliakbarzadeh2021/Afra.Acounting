using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrSellersRepository : Repository<CmrSellers> , ICmrSellersRepository
    {
        public CmrSellersRepository(DataContext context) : base(context)
        {
        }
    }
}
