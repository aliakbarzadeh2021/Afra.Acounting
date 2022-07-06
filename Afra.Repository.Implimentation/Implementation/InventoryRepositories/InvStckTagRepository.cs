using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStckTagRepository : Repository<InvStckTag> , IInvStckTagRepository
    {
        public InvStckTagRepository(DataContext context) : base(context)
        {
        }
    }
}
