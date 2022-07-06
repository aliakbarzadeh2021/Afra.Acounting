using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmVacancyRepository : Repository<HrmVacancy> , IHrmVacancyRepository
    {
        public HrmVacancyRepository(DataContext context) : base(context)
        {
        }
    }
}
