using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TaxDutyInfRepository : Repository<TaxDutyInf> , ITaxDutyInfRepository
    {
        public TaxDutyInfRepository(DataContext context) : base(context)
        {
        }
    }
}
