using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContAgrValsRepository : Repository<CntContAgrVals> , ICntContAgrValsRepository
    {
        public CntContAgrValsRepository(DataContext context) : base(context)
        {
        }
    }
}
