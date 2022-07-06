using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstMatQtyRepository : Repository<CstMatQty> , ICstMatQtyRepository
    {
        public CstMatQtyRepository(DataContext context) : base(context)
        {
        }
    }
}
