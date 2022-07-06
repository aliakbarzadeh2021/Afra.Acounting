using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntCrsDocumentRepository : Repository<CntCrsDocument> , ICntCrsDocumentRepository
    {
        public CntCrsDocumentRepository(DataContext context) : base(context)
        {
        }
    }
}
