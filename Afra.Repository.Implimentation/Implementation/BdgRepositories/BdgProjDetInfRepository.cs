using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjDetInfRepository : Repository<BdgProjDetInf> , IBdgProjDetInfRepository
    {
        public BdgProjDetInfRepository(DataContext context) : base(context)
        {
        }
    }
}
