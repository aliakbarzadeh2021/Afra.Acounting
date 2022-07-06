using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayUserFunsRepository : Repository<PayUserFuns> , IPayUserFunsRepository
    {
        public PayUserFunsRepository(DataContext context) : base(context)
        {
        }
    }
}
