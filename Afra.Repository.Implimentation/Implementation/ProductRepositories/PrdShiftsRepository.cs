using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdShiftsRepository : Repository<PrdShifts> , IPrdShiftsRepository
    {
        public PrdShiftsRepository(DataContext context) : base(context)
        {
        }
    }
}
