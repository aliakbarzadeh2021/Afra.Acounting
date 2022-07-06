using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsRepository : Repository<UsrPersHrmRels> , IUsrPersHrmRelsRepository
    {
        public UsrPersHrmRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
