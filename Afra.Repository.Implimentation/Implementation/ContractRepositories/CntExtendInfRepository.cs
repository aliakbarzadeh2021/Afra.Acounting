using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExtendInfRepository : Repository<CntExtendInf> , ICntExtendInfRepository
    {
        public CntExtendInfRepository(DataContext context) : base(context)
        {
        }
    }
}
