using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGuaranteeOprRepository : Repository<TrsGuaranteeOpr> , ITrsGuaranteeOprRepository
    {
        public TrsGuaranteeOprRepository(DataContext context) : base(context)
        {
        }
    }
}
