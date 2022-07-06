using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntInvoiceDetRepository : Repository<CntInvoiceDet> , ICntInvoiceDetRepository
    {
        public CntInvoiceDetRepository(DataContext context) : base(context)
        {
        }
    }
}
