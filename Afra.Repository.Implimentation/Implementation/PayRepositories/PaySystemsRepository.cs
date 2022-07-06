using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PaySystemsRepository : Repository<PaySystems> , IPaySystemsRepository
    {
        public PaySystemsRepository(DataContext context) : base(context)
        {
        }
    }
}
