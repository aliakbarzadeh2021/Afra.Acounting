using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccGLRepository : Repository<AccGL> , IAccGLRepository
    {
        public AccGLRepository(DataContext context) : base(context)
        {
        }
    }
}
