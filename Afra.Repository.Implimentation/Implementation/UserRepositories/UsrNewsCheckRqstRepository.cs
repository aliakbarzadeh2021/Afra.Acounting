using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrNewsCheckRqstRepository : Repository<UsrNewsCheckRqst> , IUsrNewsCheckRqstRepository
    {
        public UsrNewsCheckRqstRepository(DataContext context) : base(context)
        {
        }
    }
}
