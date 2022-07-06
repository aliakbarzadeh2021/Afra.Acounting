using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmBasesRepository : Repository<HrmBases> , IHrmBasesRepository
    {
        public HrmBasesRepository(DataContext context) : base(context)
        {
        }
    }
}
