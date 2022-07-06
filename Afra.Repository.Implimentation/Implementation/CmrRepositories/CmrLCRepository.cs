using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrLCRepository : Repository<CmrLC> , ICmrLCRepository
    {
        public CmrLCRepository(DataContext context) : base(context)
        {
        }
    }
}
