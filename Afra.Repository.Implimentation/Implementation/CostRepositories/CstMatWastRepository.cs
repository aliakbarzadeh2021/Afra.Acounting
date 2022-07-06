using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstMatWastRepository : Repository<CstMatWast> , ICstMatWastRepository
    {
        public CstMatWastRepository(DataContext context) : base(context)
        {
        }
    }
}
