using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdMachineRepository : Repository<PrdMachine> , IPrdMachineRepository
    {
        public PrdMachineRepository(DataContext context) : base(context)
        {
        }
    }
}
