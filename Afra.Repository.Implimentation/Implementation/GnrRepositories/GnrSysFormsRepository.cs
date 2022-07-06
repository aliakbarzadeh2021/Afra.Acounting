using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysFormsRepository : Repository<GnrSysForms> , IGnrSysFormsRepository
    {
        public GnrSysFormsRepository(DataContext context) : base(context)
        {
        }
    }
}
