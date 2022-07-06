using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBrokerSalaryRepository : Repository<SleBrokerSalary> , ISleBrokerSalaryRepository
    {
        public SleBrokerSalaryRepository(DataContext context) : base(context)
        {
        }
    }
}
