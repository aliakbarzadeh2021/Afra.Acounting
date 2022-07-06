using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAccntRelsRepository : Repository<CntExpAccntRels> , ICntExpAccntRelsRepository
    {
        public CntExpAccntRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
