using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersEduRepository : Repository<HrmPersEdu> , IHrmPersEduRepository
    {
        public HrmPersEduRepository(DataContext context) : base(context)
        {
        }
    }
}
