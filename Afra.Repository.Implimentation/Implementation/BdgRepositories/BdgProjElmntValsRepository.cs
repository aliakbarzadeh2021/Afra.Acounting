using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjElmntValsRepository : Repository<BdgProjElmntVals> , IBdgProjElmntValsRepository
    {
        public BdgProjElmntValsRepository(DataContext context) : base(context)
        {
        }
    }
}
