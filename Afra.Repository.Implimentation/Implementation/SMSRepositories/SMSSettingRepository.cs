using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SMSSettingRepository : Repository<SMSSetting> , ISMSSettingRepository
    {
        public SMSSettingRepository(DataContext context) : base(context)
        {
        }
    }
}
