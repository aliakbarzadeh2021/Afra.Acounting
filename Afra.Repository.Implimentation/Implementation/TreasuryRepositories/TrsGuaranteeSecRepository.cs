using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGuaranteeSecRepository : Repository<TrsGuaranteeSec> , ITrsGuaranteeSecRepository
    {
        public TrsGuaranteeSecRepository(DataContext context) : base(context)
        {
        }
    }
}
