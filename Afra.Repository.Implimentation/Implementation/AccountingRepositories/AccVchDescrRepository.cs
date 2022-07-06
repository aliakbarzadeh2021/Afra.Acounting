using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccVchDescrRepository : Repository<AccVchDescr> , IAccVchDescrRepository
    {
        public AccVchDescrRepository(DataContext context) : base(context)
        {
        }
    }
}
