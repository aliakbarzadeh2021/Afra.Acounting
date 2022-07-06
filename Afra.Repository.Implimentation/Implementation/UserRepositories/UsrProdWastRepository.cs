using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrProdWastRepository : Repository<UsrProdWast> , IUsrProdWastRepository
    {
        public UsrProdWastRepository(DataContext context) : base(context)
        {
        }
    }
}
