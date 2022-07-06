using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CurrencyRepository : Repository<Currency> , ICurrencyRepository
    {
        public CurrencyRepository(DataContext context) : base(context)
        {
        }
    }
}
