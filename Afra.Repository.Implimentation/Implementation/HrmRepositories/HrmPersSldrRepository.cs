using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersSldrRepository : Repository<HrmPersSldr> , IHrmPersSldrRepository
    {
        public HrmPersSldrRepository(DataContext context) : base(context)
        {
        }
    }
}
