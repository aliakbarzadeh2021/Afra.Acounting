using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAccVchTypesRepository : Repository<CntAccVchTypes> , ICntAccVchTypesRepository
    {
        public CntAccVchTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
