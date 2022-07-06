using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsConsRepository : Repository<UsrPersHrmRelsCons> , IUsrPersHrmRelsConsRepository
    {
        public UsrPersHrmRelsConsRepository(DataContext context) : base(context)
        {
        }
    }
}
