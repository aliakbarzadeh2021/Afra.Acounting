using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleTypesRepository : Repository<SleTypes> , ISleTypesRepository
    {
        public SleTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
