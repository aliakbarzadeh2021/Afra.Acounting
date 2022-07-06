using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleSrvItmRepository : Repository<SleSrvItm> , ISleSrvItmRepository
    {
        public SleSrvItmRepository(DataContext context) : base(context)
        {
        }
    }
}
