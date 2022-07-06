using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CrspndsRepository : Repository<Crspnds> , ICrspndsRepository
    {
        public CrspndsRepository(DataContext context) : base(context)
        {
        }
    }
}
