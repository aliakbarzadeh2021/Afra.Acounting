using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrDashFieldsRepository : Repository<GnrDashFields> , IGnrDashFieldsRepository
    {
        public GnrDashFieldsRepository(DataContext context) : base(context)
        {
        }
    }
}
