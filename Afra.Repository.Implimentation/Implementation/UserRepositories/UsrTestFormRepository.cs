using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrTestFormRepository : Repository<UsrTestForm> , IUsrTestFormRepository
    {
        public UsrTestFormRepository(DataContext context) : base(context)
        {
        }
    }
}
