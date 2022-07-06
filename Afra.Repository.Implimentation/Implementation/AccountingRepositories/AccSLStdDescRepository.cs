using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccSLStdDescRepository : Repository<AccSLStdDesc> , IAccSLStdDescRepository
    {
        public AccSLStdDescRepository(DataContext context) : base(context)
        {
        }
    }
}
