using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContractorsRepository : Repository<CntContractors> , ICntContractorsRepository
    {
        public CntContractorsRepository(DataContext context) : base(context)
        {
        }
    }
}
