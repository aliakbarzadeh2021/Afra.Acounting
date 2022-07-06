using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchTypesRepository : Repository<InvVchTypes> , IInvVchTypesRepository
    {
        public InvVchTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
