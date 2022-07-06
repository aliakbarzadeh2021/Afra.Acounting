using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleVchQtyValRepository : Repository<SleVchQtyVal> , ISleVchQtyValRepository
    {
        public SleVchQtyValRepository(DataContext context) : base(context)
        {
        }
    }
}
