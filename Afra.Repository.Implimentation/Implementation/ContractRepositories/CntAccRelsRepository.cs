using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAccRelsRepository : Repository<CntAccRels> , ICntAccRelsRepository
    {
        public CntAccRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
