using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStkPitchsRepository : Repository<InvStkPitchs> , IInvStkPitchsRepository
    {
        public InvStkPitchsRepository(DataContext context) : base(context)
        {
        }
    }
}
