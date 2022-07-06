using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrAlarmDetRepository : Repository<GnrAlarmDet> , IGnrAlarmDetRepository
    {
        public GnrAlarmDetRepository(DataContext context) : base(context)
        {
        }
    }
}
