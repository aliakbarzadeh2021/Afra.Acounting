using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccVchTypesRepository : Repository<AccVchTypes> , IAccVchTypesRepository
    {
        public AccVchTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
