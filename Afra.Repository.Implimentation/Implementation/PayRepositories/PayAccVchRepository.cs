using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayAccVchRepository : Repository<PayAccVch> , IPayAccVchRepository
    {
        public PayAccVchRepository(DataContext context) : base(context)
        {
        }
    }
}
