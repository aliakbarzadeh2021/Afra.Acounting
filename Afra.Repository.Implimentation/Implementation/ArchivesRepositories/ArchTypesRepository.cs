using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ArchTypesRepository : Repository<ArchTypes> , IArchTypesRepository
    {
        public ArchTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
