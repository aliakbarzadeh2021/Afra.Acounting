using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccVchHdrRepository : Repository<AccVchHdr> , IAccVchHdrRepository
    {
        public AccVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
