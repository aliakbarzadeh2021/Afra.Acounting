using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCalcCtrlRepository : Repository<PayCalcCtrl> , IPayCalcCtrlRepository
    {
        public PayCalcCtrlRepository(DataContext context) : base(context)
        {
        }
    }
}
