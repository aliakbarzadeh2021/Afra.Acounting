using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmCalendarsRepository : Repository<HrmCalendars> , IHrmCalendarsRepository
    {
        public HrmCalendarsRepository(DataContext context) : base(context)
        {
        }
    }
}
