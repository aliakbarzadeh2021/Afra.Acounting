using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayGrpLoanRepository : Repository<PayGrpLoan> , IPayGrpLoanRepository
    {
        public PayGrpLoanRepository(DataContext context) : base(context)
        {
        }
    }
}
