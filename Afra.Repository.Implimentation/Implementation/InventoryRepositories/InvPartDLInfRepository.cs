using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartDLInfRepository : Repository<InvPartDLInf> , IInvPartDLInfRepository
    {
        public InvPartDLInfRepository(DataContext context) : base(context)
        {
        }
    }
}
