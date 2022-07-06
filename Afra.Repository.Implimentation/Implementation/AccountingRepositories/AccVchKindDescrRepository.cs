using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccVchKindDescrRepository : Repository<AccVchKindDescr> , IAccVchKindDescrRepository
    {
        public AccVchKindDescrRepository(DataContext context) : base(context)
        {
        }
    }
}
