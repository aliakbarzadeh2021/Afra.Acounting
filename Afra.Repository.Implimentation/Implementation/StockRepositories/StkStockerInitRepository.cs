using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class StkStockerInitRepository : Repository<StkStockerInit> , IStkStockerInitRepository
    {
        public StkStockerInitRepository(DataContext context) : base(context)
        {
        }
    }
}
