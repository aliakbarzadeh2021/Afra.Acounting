using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjectsRepository : Repository<BdgProjects> , IBdgProjectsRepository
    {
        public BdgProjectsRepository(DataContext context) : base(context)
        {
        }
    }
}
