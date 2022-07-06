using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WebDocsRepository : Repository<WebDocs> , IWebDocsRepository
    {
        public WebDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
