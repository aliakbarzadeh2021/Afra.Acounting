using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrTest1Repository : Repository<UsrTest1> , IUsrTest1Repository
    {
        public UsrTest1Repository(DataContext context) : base(context)
        {
        }
    }
}
