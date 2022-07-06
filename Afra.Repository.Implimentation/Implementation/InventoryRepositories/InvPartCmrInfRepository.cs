using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartCmrInfRepository : Repository<InvPartCmrInf> , IInvPartCmrInfRepository
    {
        public InvPartCmrInfRepository(DataContext context) : base(context)
        {
        }
    }
}
