using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCalcValsRepository : Repository<PayCalcVals> , IPayCalcValsRepository
    {
        public PayCalcValsRepository(DataContext context) : base(context)
        {
        }
    }
}
