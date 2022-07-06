using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRefFormsListRepository : Repository<GnrRefFormsList> , IGnrRefFormsListRepository
    {
        public GnrRefFormsListRepository(DataContext context) : base(context)
        {
        }
    }
}
