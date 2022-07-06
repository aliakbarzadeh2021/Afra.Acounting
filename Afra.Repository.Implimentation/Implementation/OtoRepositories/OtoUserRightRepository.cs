using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoUserRightRepository : Repository<OtoUserRight> , IOtoUserRightRepository
    {
        public OtoUserRightRepository(DataContext context) : base(context)
        {
        }
    }
}
