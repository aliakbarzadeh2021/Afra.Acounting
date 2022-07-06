using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccGLVchItmRepository : Repository<AccGLVchItm> , IAccGLVchItmRepository
    {
        public AccGLVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
