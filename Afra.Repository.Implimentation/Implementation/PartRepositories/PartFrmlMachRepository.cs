using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PartFrmlMachRepository : Repository<PartFrmlMach> , IPartFrmlMachRepository
    {
        public PartFrmlMachRepository(DataContext context) : base(context)
        {
        }
    }
}
