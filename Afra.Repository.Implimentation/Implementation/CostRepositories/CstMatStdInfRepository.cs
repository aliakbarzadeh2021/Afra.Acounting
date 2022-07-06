using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstMatStdInfRepository : Repository<CstMatStdInf> , ICstMatStdInfRepository
    {
        public CstMatStdInfRepository(DataContext context) : base(context)
        {
        }
    }
}
