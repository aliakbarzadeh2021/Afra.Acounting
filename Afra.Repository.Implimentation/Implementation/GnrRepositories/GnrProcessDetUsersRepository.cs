using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetUsersRepository : Repository<GnrProcessDetUsers> , IGnrProcessDetUsersRepository
    {
        public GnrProcessDetUsersRepository(DataContext context) : base(context)
        {
        }
    }
}
