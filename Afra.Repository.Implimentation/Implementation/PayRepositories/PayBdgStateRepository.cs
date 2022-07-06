using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayBdgStateRepository : Repository<PayBdgState> , IPayBdgStateRepository
    {
        public PayBdgStateRepository(DataContext context) : base(context)
        {
        }
    }
}
