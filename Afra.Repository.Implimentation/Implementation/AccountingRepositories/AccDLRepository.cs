using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccDLRepository : Repository<AccDL> , IAccDLRepository
    {
        public AccDLRepository(DataContext context) : base(context)
        {
        }
    }
}
