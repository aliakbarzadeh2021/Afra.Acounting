using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCalcStateRepository : Repository<PayCalcState> , IPayCalcStateRepository
    {
        public PayCalcStateRepository(DataContext context) : base(context)
        {
        }
    }
}
