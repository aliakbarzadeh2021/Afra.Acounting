using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoTemplatesRepository : Repository<OtoTemplates> , IOtoTemplatesRepository
    {
        public OtoTemplatesRepository(DataContext context) : base(context)
        {
        }
    }
}
