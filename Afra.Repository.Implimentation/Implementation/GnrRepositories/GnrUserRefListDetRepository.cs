using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserRefListDetRepository : Repository<GnrUserRefListDet> , IGnrUserRefListDetRepository
    {
        public GnrUserRefListDetRepository(DataContext context) : base(context)
        {
        }
    }
}
