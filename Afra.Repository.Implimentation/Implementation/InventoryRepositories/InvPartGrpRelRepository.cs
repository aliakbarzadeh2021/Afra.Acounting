using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartGrpRelRepository : Repository<InvPartGrpRel> , IInvPartGrpRelRepository
    {
        public InvPartGrpRelRepository(DataContext context) : base(context)
        {
        }
    }
}
