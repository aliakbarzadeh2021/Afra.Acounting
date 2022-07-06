using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsDocRepository : Repository<UsrPersHrmRelsDoc> , IUsrPersHrmRelsDocRepository
    {
        public UsrPersHrmRelsDocRepository(DataContext context) : base(context)
        {
        }
    }
}
