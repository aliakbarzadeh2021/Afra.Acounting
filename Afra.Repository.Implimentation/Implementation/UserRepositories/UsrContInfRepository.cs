using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrContInfRepository : Repository<UsrContInf> , IUsrContInfRepository
    {
        public UsrContInfRepository(DataContext context) : base(context)
        {
        }
    }
}
