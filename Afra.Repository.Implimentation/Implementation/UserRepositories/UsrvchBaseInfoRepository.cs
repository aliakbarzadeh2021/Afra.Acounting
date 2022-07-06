using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrvchBaseInfoRepository : Repository<UsrvchBaseInfo> , IUsrvchBaseInfoRepository
    {
        public UsrvchBaseInfoRepository(DataContext context) : base(context)
        {
        }
    }
}
