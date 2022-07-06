using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoFlowCrsRepository : Repository<OtoFlowCrs> , IOtoFlowCrsRepository
    {
        public OtoFlowCrsRepository(DataContext context) : base(context)
        {
        }
    }
}
