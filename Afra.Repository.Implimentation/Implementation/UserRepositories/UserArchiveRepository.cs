using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserArchiveRepository : Repository<UserArchive> , IUserArchiveRepository
    {
        public UserArchiveRepository(DataContext context) : base(context)
        {
        }
    }
}
