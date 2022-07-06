using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCalcCtrlDetRepository : Repository<PayCalcCtrlDet> , IPayCalcCtrlDetRepository
    {
        public PayCalcCtrlDetRepository(DataContext context) : base(context)
        {
        }
    }
}
