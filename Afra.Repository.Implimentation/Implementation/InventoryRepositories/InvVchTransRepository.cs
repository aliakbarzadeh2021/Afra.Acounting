using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchTransRepository : Repository<InvVchTrans> , IInvVchTransRepository
    {
        public InvVchTransRepository(DataContext context) : base(context)
        {
        }
    }
}
