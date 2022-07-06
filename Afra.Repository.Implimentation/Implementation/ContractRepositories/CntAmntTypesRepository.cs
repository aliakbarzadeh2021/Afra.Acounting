using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAmntTypesRepository : Repository<CntAmntTypes> , ICntAmntTypesRepository
    {
        public CntAmntTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
