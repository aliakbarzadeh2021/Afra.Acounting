using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntMasterFactorRepository : Repository<CntMasterFactor> , ICntMasterFactorRepository
    {
        public CntMasterFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
