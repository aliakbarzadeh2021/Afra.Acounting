using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFundOprRepository : Repository<TrsFundOpr> , ITrsFundOprRepository
    {
        public TrsFundOprRepository(DataContext context) : base(context)
        {
        }
    }
}
