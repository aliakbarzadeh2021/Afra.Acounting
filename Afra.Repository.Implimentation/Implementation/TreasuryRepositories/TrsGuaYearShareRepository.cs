using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGuaYearShareRepository : Repository<TrsGuaYearShare> , ITrsGuaYearShareRepository
    {
        public TrsGuaYearShareRepository(DataContext context) : base(context)
        {
        }
    }
}
