using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrAlarmTypesRepository : Repository<GnrAlarmTypes> , IGnrAlarmTypesRepository
    {
        public GnrAlarmTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
