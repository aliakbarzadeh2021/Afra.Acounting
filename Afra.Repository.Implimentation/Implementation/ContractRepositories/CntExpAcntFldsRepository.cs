using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAcntFldsRepository : Repository<CntExpAcntFlds> , ICntExpAcntFldsRepository
    {
        public CntExpAcntFldsRepository(DataContext context) : base(context)
        {
        }
    }
}
