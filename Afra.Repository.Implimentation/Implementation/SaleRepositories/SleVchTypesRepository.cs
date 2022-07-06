using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleVchTypesRepository : Repository<SleVchTypes> , ISleVchTypesRepository
    {
        public SleVchTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
