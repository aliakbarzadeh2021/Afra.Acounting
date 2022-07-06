using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOperationRepository : Repository<PrdOperation> , IPrdOperationRepository
    {
        public PrdOperationRepository(DataContext context) : base(context)
        {
        }
    }
}
