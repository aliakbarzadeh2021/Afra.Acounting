using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContractsRepository : Repository<CntContracts> , ICntContractsRepository
    {
        public CntContractsRepository(DataContext context) : base(context)
        {
        }
    }
}
