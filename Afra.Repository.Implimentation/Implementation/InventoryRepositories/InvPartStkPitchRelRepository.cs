using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartStkPitchRelRepository : Repository<InvPartStkPitchRel> , IInvPartStkPitchRelRepository
    {
        public InvPartStkPitchRelRepository(DataContext context) : base(context)
        {
        }
    }
}
