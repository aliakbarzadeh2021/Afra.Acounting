using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstProductVchRepository : Repository<CstProductVch> , ICstProductVchRepository
    {
        public CstProductVchRepository(DataContext context) : base(context)
        {
        }
    }
}
