using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstProduceInfRepository : Repository<CstProduceInf> , ICstProduceInfRepository
    {
        public CstProduceInfRepository(DataContext context) : base(context)
        {
        }
    }
}
