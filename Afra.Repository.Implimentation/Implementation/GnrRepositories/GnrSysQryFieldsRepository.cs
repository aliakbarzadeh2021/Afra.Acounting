using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysQryFieldsRepository : Repository<GnrSysQryFields> , IGnrSysQryFieldsRepository
    {
        public GnrSysQryFieldsRepository(DataContext context) : base(context)
        {
        }
    }
}
