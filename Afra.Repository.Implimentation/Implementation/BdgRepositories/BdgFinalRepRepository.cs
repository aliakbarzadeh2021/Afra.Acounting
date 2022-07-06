using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgFinalRepRepository : Repository<BdgFinalRep> , IBdgFinalRepRepository
    {
        public BdgFinalRepRepository(DataContext context) : base(context)
        {
        }
    }
}
