using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleSrvTaxRepository : Repository<SleSrvTax> , ISleSrvTaxRepository
    {
        public SleSrvTaxRepository(DataContext context) : base(context)
        {
        }
    }
}
