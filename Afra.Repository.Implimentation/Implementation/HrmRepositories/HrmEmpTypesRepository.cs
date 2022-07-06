using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmEmpTypesRepository : Repository<HrmEmpTypes> , IHrmEmpTypesRepository
    {
        public HrmEmpTypesRepository(DataContext context) : base(context)
        {
        }
    }
}
