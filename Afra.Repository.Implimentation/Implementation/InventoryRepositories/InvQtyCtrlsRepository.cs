using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvQtyCtrlsRepository : Repository<InvQtyCtrls> , IInvQtyCtrlsRepository
    {
        public InvQtyCtrlsRepository(DataContext context) : base(context)
        {
        }
    }
}
