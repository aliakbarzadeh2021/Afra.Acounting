using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccSLRepository : Repository<AccSL> , IAccSLRepository
    {
        public AccSLRepository(DataContext context) : base(context)
        {
        }
    }
}
