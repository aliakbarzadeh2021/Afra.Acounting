using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserFieldRepository : Repository<GnrUserField> , IGnrUserFieldRepository
    {
        public GnrUserFieldRepository(DataContext context) : base(context)
        {
        }
    }
}
