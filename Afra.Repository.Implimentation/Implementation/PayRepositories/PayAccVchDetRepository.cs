using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayAccVchDetRepository : Repository<PayAccVchDet> , IPayAccVchDetRepository
    {
        public PayAccVchDetRepository(DataContext context) : base(context)
        {
        }
    }
}
