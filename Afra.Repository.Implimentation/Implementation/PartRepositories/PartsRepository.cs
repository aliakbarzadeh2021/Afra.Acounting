using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PartsRepository : Repository<Parts> , IPartsRepository
    {
        public PartsRepository(DataContext context) : base(context)
        {
        }
    }
}
