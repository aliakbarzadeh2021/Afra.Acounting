using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstProdDurQtyRepository : Repository<CstProdDurQty> , ICstProdDurQtyRepository
    {
        public CstProdDurQtyRepository(DataContext context) : base(context)
        {
        }
    }
}
