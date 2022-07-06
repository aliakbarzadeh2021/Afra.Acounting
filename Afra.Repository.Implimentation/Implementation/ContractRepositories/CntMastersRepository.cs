using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntMastersRepository : Repository<CntMasters> , ICntMastersRepository
    {
        public CntMastersRepository(DataContext context) : base(context)
        {
        }
    }
}
