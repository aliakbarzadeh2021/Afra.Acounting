using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrFormRepRelsRepository : Repository<GnrFormRepRels> , IGnrFormRepRelsRepository
    {
        public GnrFormRepRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
