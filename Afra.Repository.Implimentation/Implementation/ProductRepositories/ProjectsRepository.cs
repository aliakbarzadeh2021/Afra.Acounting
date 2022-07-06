using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ProjectsRepository : Repository<Projects> , IProjectsRepository
    {
        public ProjectsRepository(DataContext context) : base(context)
        {
        }
    }
}
