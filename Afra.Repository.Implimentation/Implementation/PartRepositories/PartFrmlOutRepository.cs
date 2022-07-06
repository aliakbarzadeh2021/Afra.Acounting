using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PartFrmlOutRepository : Repository<PartFrmlOut> , IPartFrmlOutRepository
    {
        public PartFrmlOutRepository(DataContext context) : base(context)
        {
        }
    }
}
