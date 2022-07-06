using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ElmntMethodRepository : Repository<ElmntMethod> , IElmntMethodRepository
    {
        public ElmntMethodRepository(DataContext context) : base(context)
        {
        }
    }
}
