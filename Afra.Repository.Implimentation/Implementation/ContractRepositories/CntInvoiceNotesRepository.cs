using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntInvoiceNotesRepository : Repository<CntInvoiceNotes> , ICntInvoiceNotesRepository
    {
        public CntInvoiceNotesRepository(DataContext context) : base(context)
        {
        }
    }
}
