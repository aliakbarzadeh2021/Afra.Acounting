using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrMissionDetRepository : Repository<UsrMissionDet> , IUsrMissionDetRepository
    {
        public UsrMissionDetRepository(DataContext context) : base(context)
        {
        }
    }
}
