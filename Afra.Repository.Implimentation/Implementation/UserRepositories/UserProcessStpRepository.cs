using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserProcessStpRepository : Repository<UserProcessStp> , IUserProcessStpRepository
    {
        public UserProcessStpRepository(DataContext context) : base(context)
        {
        }
    }
}
