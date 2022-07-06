using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCtrlRepository : Repository<PayCtrl> , IPayCtrlRepository
    {
        public PayCtrlRepository(DataContext context) : base(context)
        {
        }
    }
}
