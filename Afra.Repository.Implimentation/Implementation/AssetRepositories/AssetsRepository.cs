using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AssetsRepository : Repository<Assets> , IAssetsRepository
    {
        public AssetsRepository(DataContext context) : base(context)
        {
        }
    }
}
