using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstCostDetRepository : Repository<AstCostDet> , IAstCostDetRepository
    {
        public AstCostDetRepository(DataContext context) : base(context)
        {
        }
    }
}
