using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntInvoiceHdrRepository : Repository<CntInvoiceHdr> , ICntInvoiceHdrRepository
    {
        public CntInvoiceHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
