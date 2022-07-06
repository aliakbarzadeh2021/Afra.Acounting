using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayExportFilesRepository : Repository<PayExportFiles> , IPayExportFilesRepository
    {
        public PayExportFilesRepository(DataContext context) : base(context)
        {
        }
    }
}
