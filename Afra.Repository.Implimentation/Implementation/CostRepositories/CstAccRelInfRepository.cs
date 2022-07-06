using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstAccRelInfRepository : Repository<CstAccRelInf> , ICstAccRelInfRepository
    {
        public CstAccRelInfRepository(DataContext context) : base(context)
        {
        }
    }
}
