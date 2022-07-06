using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WebLoginsRepository : Repository<WebLogins> , IWebLoginsRepository
    {
        public WebLoginsRepository(DataContext context) : base(context)
        {
        }
    }
}
