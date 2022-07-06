using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayLoanRcvRepository : Repository<PayLoanRcv> , IPayLoanRcvRepository
    {
        public PayLoanRcvRepository(DataContext context) : base(context)
        {
        }
    }
}
