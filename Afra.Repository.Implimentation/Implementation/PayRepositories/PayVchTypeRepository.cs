using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayVchTypeRepository : Repository<PayVchType> , IPayVchTypeRepository
    {
        public PayVchTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
