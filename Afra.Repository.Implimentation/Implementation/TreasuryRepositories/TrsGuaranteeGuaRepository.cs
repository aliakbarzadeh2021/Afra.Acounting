using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGuaranteeGuaRepository : Repository<TrsGuaranteeGua> , ITrsGuaranteeGuaRepository
    {
        public TrsGuaranteeGuaRepository(DataContext context) : base(context)
        {
        }
    }
}
