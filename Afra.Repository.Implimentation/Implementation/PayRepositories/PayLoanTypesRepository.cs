using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayLoanTypesRepository : Repository<PayLoanTypes> , IPayLoanTypesRepository
    {
        public PayLoanTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
