using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserStorageRepository : Repository<GnrUserStorage> , IGnrUserStorageRepository
    {
        public GnrUserStorageRepository(DataContext context) : base(context)
        {
        }
    }
}
