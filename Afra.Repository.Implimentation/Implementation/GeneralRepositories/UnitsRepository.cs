using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UnitsRepository : Repository<Units> , IUnitsRepository
    {
        public UnitsRepository(DataContext context) : base(context)
        {
        }
    }
}
