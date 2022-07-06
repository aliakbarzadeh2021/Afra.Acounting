using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntFormValsRepository : Repository<CntFormVals> , ICntFormValsRepository
    {
        public CntFormValsRepository(DataContext context) : base(context)
        {
        }
    }
}
