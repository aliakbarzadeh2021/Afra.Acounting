using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdSendItmRepository : Repository<PrdSendItm> , IPrdSendItmRepository
    {
        public PrdSendItmRepository(DataContext context) : base(context)
        {
        }
    }
}
