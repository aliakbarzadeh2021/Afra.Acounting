using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacCrdTblDetRepository : Repository<TrsFacCrdTblDet> , ITrsFacCrdTblDetRepository
    {
        public TrsFacCrdTblDetRepository(DataContext context) : base(context)
        {
        }
    }
}
