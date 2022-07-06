using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacTypeInfRepository : Repository<TrsFacTypeInf> , ITrsFacTypeInfRepository
    {
        public TrsFacTypeInfRepository(DataContext context) : base(context)
        {
        }
    }
}
