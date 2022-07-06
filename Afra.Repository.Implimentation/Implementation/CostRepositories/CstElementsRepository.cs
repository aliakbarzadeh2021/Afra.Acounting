using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstElementsRepository : Repository<CstElements> , ICstElementsRepository
    {
        public CstElementsRepository(DataContext context) : base(context)
        {
        }
    }
}
