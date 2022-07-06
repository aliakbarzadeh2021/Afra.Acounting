using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRefFormsListDetRepository : Repository<GnrRefFormsListDet> , IGnrRefFormsListDetRepository
    {
        public GnrRefFormsListDetRepository(DataContext context) : base(context)
        {
        }
    }
}
