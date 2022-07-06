using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTaxesRepository : Repository<BdgTaxes> , IBdgTaxesRepository
    {
        public BdgTaxesRepository(DataContext context) : base(context)
        {
        }
    }
}
