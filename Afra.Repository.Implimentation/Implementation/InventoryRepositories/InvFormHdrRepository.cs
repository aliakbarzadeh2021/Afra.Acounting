using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvFormHdrRepository : Repository<InvFormHdr> , IInvFormHdrRepository
    {
        public InvFormHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
