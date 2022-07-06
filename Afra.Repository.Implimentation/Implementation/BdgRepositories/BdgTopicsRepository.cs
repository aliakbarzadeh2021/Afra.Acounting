using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTopicsRepository : Repository<BdgTopics> , IBdgTopicsRepository
    {
        public BdgTopicsRepository(DataContext context) : base(context)
        {
        }
    }
}
