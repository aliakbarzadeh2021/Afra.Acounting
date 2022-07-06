using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrProdVchRepository : Repository<UsrProdVch> , IUsrProdVchRepository
    {
        public UsrProdVchRepository(DataContext context) : base(context)
        {
        }
    }
}
