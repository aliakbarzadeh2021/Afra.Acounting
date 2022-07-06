using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleGuaDocsRepository : Repository<SleGuaDocs> , ISleGuaDocsRepository
    {
        public SleGuaDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
