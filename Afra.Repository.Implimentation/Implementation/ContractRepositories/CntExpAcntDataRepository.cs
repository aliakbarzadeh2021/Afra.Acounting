using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAcntDataRepository : Repository<CntExpAcntData> , ICntExpAcntDataRepository
    {
        public CntExpAcntDataRepository(DataContext context) : base(context)
        {
        }
    }
}
