using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SMSOperateRepository : Repository<SMSOperate> , ISMSOperateRepository
    {
        public SMSOperateRepository(DataContext context) : base(context)
        {
        }
    }
}
