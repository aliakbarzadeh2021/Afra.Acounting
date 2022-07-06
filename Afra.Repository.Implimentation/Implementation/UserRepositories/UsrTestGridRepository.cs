using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrTestGridRepository : Repository<UsrTestGrid> , IUsrTestGridRepository
    {
        public UsrTestGridRepository(DataContext context) : base(context)
        {
        }
    }
}
