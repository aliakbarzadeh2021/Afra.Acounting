using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WebImagesRepository : Repository<WebImages> , IWebImagesRepository
    {
        public WebImagesRepository(DataContext context) : base(context)
        {
        }
    }
}
