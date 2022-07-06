using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccAnalyseRepository : Repository<AccAnalyse> , IAccAnalyseRepository
    {
        public AccAnalyseRepository(DataContext context) : base(context)
        {
        }
    }
}
