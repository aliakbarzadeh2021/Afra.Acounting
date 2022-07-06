using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayLoanPaymentRepository : Repository<PayLoanPayment> , IPayLoanPaymentRepository
    {
        public PayLoanPaymentRepository(DataContext context) : base(context)
        {
        }
    }
}
