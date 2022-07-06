using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserFormOprsRepository : Repository<GnrUserFormOprs> , IGnrUserFormOprsRepository
    {
        public GnrUserFormOprsRepository(DataContext context) : base(context)
        {
        }
    }
}
