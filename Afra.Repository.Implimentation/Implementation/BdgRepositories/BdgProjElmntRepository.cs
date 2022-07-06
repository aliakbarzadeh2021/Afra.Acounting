using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjElmntRepository : Repository<BdgProjElmnt> , IBdgProjElmntRepository
    {
        public BdgProjElmntRepository(DataContext context) : base(context)
        {
        }
    }
}
