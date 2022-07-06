using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmAimFormDetRepository : Repository<HrmAimFormDet> , IHrmAimFormDetRepository
    {
        public HrmAimFormDetRepository(DataContext context) : base(context)
        {
        }
    }
}
