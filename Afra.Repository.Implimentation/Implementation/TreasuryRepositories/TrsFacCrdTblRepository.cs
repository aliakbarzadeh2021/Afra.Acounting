using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacCrdTblRepository : Repository<TrsFacCrdTbl> , ITrsFacCrdTblRepository
    {
        public TrsFacCrdTblRepository(DataContext context) : base(context)
        {
        }
    }
}
