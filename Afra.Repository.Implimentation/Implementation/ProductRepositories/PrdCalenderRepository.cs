using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdCalenderRepository : Repository<PrdCalender> , IPrdCalenderRepository
    {
        public PrdCalenderRepository(DataContext context) : base(context)
        {
        }
    }
}
