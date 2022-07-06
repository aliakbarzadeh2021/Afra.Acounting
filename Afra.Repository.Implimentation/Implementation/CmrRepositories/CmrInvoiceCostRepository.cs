using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrInvoiceCostRepository : Repository<CmrInvoiceCost> , ICmrInvoiceCostRepository
    {
        public CmrInvoiceCostRepository(DataContext context) : base(context)
        {
        }
    }
}
