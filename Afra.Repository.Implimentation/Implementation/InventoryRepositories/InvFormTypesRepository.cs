using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvFormTypesRepository : Repository<InvFormTypes> , IInvFormTypesRepository
    {
        public InvFormTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
