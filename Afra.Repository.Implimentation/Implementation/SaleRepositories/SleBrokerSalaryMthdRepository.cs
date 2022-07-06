using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBrokerSalaryMthdRepository : Repository<SleBrokerSalaryMthd> , ISleBrokerSalaryMthdRepository
    {
        public SleBrokerSalaryMthdRepository(DataContext context) : base(context)
        {
        }
    }
}
