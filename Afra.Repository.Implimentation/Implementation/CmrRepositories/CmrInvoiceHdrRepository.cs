using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrInvoiceHdrRepository : Repository<CmrInvoiceHdr> , ICmrInvoiceHdrRepository
    {
        public CmrInvoiceHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
