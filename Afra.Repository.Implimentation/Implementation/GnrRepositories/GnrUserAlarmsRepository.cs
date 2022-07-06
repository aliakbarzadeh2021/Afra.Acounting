using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserAlarmsRepository : Repository<GnrUserAlarms> , IGnrUserAlarmsRepository
    {
        public GnrUserAlarmsRepository(DataContext context) : base(context)
        {
        }
    }
}
