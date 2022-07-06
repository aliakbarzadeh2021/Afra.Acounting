using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrNumVchCfgDetRepository : Repository<GnrNumVchCfgDet> , IGnrNumVchCfgDetRepository
    {
        public GnrNumVchCfgDetRepository(DataContext context) : base(context)
        {
        }
    }
}
