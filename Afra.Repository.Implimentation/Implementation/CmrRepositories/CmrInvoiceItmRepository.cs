using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrInvoiceItmRepository : Repository<CmrInvoiceItm> , ICmrInvoiceItmRepository
    {
        public CmrInvoiceItmRepository(DataContext context) : base(context)
        {
        }
    }
}
