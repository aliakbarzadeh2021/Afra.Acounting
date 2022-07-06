using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoFilesRepository : Repository<OtoFiles> , IOtoFilesRepository
    {
        public OtoFilesRepository(DataContext context) : base(context)
        {
        }
    }
}
