using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrInsuranceRepository : Repository<CmrInsurance> , ICmrInsuranceRepository
    {
        public CmrInsuranceRepository(DataContext context) : base(context)
        {
        }
    }
}
