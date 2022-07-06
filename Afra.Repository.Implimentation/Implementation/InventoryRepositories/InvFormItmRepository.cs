using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvFormItmRepository : Repository<InvFormItm> , IInvFormItmRepository
    {
        public InvFormItmRepository(DataContext context) : base(context)
        {
        }
    }
}
