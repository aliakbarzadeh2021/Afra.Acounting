using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoTransScriptRepository : Repository<OtoTransScript> , IOtoTransScriptRepository
    {
        public OtoTransScriptRepository(DataContext context) : base(context)
        {
        }
    }
}
