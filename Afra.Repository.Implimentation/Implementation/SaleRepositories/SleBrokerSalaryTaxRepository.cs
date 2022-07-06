using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBrokerSalaryTaxRepository : Repository<SleBrokerSalaryTax> , ISleBrokerSalaryTaxRepository
    {
        public SleBrokerSalaryTaxRepository(DataContext context) : base(context)
        {
        }
    }
}
