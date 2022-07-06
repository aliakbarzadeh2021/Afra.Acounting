using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntInvoiceRelsRepository : Repository<CntInvoiceRels> , ICntInvoiceRelsRepository
    {
        public CntInvoiceRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
