using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsAccOprRepository : Repository<TrsAccOpr> , ITrsAccOprRepository
    {
        public TrsAccOprRepository(DataContext context) : base(context)
        {
        }
    }
}
