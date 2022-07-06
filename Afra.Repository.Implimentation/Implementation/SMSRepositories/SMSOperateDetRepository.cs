using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SMSOperateDetRepository : Repository<SMSOperateDet> , ISMSOperateDetRepository
    {
        public SMSOperateDetRepository(DataContext context) : base(context)
        {
        }
    }
}
