using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayBuyCalcRepository : Repository<PayBuyCalc> , IPayBuyCalcRepository
    {
        public PayBuyCalcRepository(DataContext context) : base(context)
        {
        }
    }
}
