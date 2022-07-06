using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOprDetInfRepository : Repository<PrdOprDetInf> , IPrdOprDetInfRepository
    {
        public PrdOprDetInfRepository(DataContext context) : base(context)
        {
        }
    }
}
