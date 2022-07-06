using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayImportFilesRepository : Repository<PayImportFiles> , IPayImportFilesRepository
    {
        public PayImportFilesRepository(DataContext context) : base(context)
        {
        }
    }
}
