using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstPeriodsRepository : Repository<CstPeriods> , ICstPeriodsRepository
    {
        public CstPeriodsRepository(DataContext context) : base(context)
        {
        }
    }
}
