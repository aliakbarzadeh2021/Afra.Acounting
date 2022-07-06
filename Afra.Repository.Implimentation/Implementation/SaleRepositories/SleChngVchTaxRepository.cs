using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleChngVchTaxRepository : Repository<SleChngVchTax> , ISleChngVchTaxRepository
    {
        public SleChngVchTaxRepository(DataContext context) : base(context)
        {
        }
    }
}
