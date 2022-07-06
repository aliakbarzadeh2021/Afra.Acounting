using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstStdAccDataRepository : Repository<CstStdAccData> , ICstStdAccDataRepository
    {
        public CstStdAccDataRepository(DataContext context) : base(context)
        {
        }
    }
}
