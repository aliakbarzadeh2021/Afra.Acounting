using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAcquitInfsRepository : Repository<CntAcquitInfs> , ICntAcquitInfsRepository
    {
        public CntAcquitInfsRepository(DataContext context) : base(context)
        {
        }
    }
}
