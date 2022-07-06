using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayGrpLoanPersRepository : Repository<PayGrpLoanPers> , IPayGrpLoanPersRepository
    {
        public PayGrpLoanPersRepository(DataContext context) : base(context)
        {
        }
    }
}
