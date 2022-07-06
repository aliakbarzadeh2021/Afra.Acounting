using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleGuaranteeRepository : Repository<SleGuarantee> , ISleGuaranteeRepository
    {
        public SleGuaranteeRepository(DataContext context) : base(context)
        {
        }
    }
}
