using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayLoanHistoryRepository : Repository<PayLoanHistory> , IPayLoanHistoryRepository
    {
        public PayLoanHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
