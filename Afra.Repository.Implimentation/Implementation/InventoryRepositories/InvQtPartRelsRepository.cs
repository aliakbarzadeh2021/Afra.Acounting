using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvQtPartRelsRepository : Repository<InvQtPartRels> , IInvQtPartRelsRepository
    {
        public InvQtPartRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
