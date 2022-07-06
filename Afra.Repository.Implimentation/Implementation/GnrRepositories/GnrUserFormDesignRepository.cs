using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserFormDesignRepository : Repository<GnrUserFormDesign> , IGnrUserFormDesignRepository
    {
        public GnrUserFormDesignRepository(DataContext context) : base(context)
        {
        }
    }
}
