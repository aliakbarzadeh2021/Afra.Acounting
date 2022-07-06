using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrCrsOthInfRepository : Repository<UsrCrsOthInf> , IUsrCrsOthInfRepository
    {
        public UsrCrsOthInfRepository(DataContext context) : base(context)
        {
        }
    }
}
