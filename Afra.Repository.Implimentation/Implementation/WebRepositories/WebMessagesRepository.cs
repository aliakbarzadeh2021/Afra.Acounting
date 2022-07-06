using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WebMessagesRepository : Repository<WebMessages> , IWebMessagesRepository
    {
        public WebMessagesRepository(DataContext context) : base(context)
        {
        }
    }
}
