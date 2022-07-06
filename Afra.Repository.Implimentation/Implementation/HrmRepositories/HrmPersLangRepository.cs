using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersLangRepository : Repository<HrmPersLang> , IHrmPersLangRepository
    {
        public HrmPersLangRepository(DataContext context) : base(context)
        {
        }
    }
}
