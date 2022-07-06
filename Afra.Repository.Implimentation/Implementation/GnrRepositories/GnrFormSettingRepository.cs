using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrFormSettingRepository : Repository<GnrFormSetting> , IGnrFormSettingRepository
    {
        public GnrFormSettingRepository(DataContext context) : base(context)
        {
        }
    }
}
