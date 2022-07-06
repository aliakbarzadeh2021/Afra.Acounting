using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SettingsRepository : Repository<Settings> , ISettingsRepository
    {
        public SettingsRepository(DataContext context) : base(context)
        {
        }
    }
}
