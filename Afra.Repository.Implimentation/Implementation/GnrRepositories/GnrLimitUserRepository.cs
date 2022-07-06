using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrLimitUserRepository : Repository<GnrLimitUser> , IGnrLimitUserRepository
    {
        public GnrLimitUserRepository(DataContext context) : base(context)
        {
        }
    }
}
