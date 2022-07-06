using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetObjRepository : Repository<GnrProcessDetObj> , IGnrProcessDetObjRepository
    {
        public GnrProcessDetObjRepository(DataContext context) : base(context)
        {
        }
    }
}
