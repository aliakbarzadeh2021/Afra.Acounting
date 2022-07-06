using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartParamsRepository : Repository<InvPartParams> , IInvPartParamsRepository
    {
        public InvPartParamsRepository(DataContext context) : base(context)
        {
        }
    }
}
