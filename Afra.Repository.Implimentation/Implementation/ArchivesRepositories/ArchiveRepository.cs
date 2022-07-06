using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ArchiveRepository : Repository<Archive> , IArchiveRepository
    {
        public ArchiveRepository(DataContext context) : base(context)
        {
        }
    }
}
