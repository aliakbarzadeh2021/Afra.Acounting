using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsApplRepository : Repository<UsrPersHrmRelsAppl> , IUsrPersHrmRelsApplRepository
    {
        public UsrPersHrmRelsApplRepository(DataContext context) : base(context)
        {
        }
    }
}
