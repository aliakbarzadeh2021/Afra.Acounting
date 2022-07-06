using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartUnitsRepository : Repository<InvPartUnits> , IInvPartUnitsRepository
    {
        public InvPartUnitsRepository(DataContext context) : base(context)
        {
        }
    }
}
