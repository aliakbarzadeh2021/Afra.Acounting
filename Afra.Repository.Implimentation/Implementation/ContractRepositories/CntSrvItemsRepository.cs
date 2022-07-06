using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntSrvItemsRepository : Repository<CntSrvItems> , ICntSrvItemsRepository
    {
        public CntSrvItemsRepository(DataContext context) : base(context)
        {
        }
    }
}
