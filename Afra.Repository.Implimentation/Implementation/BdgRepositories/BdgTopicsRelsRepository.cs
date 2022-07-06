using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgTopicsRelsRepository : Repository<BdgTopicsRels> , IBdgTopicsRelsRepository
    {
        public BdgTopicsRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
