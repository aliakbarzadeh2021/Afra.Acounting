using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrAutoTextRepository : Repository<GnrAutoText> , IGnrAutoTextRepository
    {
        public GnrAutoTextRepository(DataContext context) : base(context)
        {
        }
    }
}
