using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstMatDurQtyRepository : Repository<CstMatDurQty> , ICstMatDurQtyRepository
    {
        public CstMatDurQtyRepository(DataContext context) : base(context)
        {
        }
    }
}
