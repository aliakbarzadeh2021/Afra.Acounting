using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccPLRepository : Repository<AccPL> , IAccPLRepository
    {
        public AccPLRepository(DataContext context) : base(context)
        {
        }
    }
}
