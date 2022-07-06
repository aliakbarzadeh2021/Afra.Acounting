using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBrokerSalaryRelsRepository : Repository<SleBrokerSalaryRels> , ISleBrokerSalaryRelsRepository
    {
        public SleBrokerSalaryRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
