using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsRehabRepository : Repository<UsrPersHrmRelsRehab> , IUsrPersHrmRelsRehabRepository
    {
        public UsrPersHrmRelsRehabRepository(DataContext context) : base(context)
        {
        }
    }
}
