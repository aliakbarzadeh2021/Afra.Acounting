using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsChqFmtRepository : Repository<TrsChqFmt> , ITrsChqFmtRepository
    {
        public TrsChqFmtRepository(DataContext context) : base(context)
        {
        }
    }
}
