using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmAimFormsRepository : Repository<HrmAimForms> , IHrmAimFormsRepository
    {
        public HrmAimFormsRepository(DataContext context) : base(context)
        {
        }
    }
}
