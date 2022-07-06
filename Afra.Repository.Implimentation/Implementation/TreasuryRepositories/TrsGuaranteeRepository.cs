using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGuaranteeRepository : Repository<TrsGuarantee> , ITrsGuaranteeRepository
    {
        public TrsGuaranteeRepository(DataContext context) : base(context)
        {
        }
    }
}
