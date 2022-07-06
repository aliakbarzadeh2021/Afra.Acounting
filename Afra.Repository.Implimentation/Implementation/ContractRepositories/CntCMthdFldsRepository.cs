using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntCMthdFldsRepository : Repository<CntCMthdFlds> , ICntCMthdFldsRepository
    {
        public CntCMthdFldsRepository(DataContext context) : base(context)
        {
        }
    }
}
