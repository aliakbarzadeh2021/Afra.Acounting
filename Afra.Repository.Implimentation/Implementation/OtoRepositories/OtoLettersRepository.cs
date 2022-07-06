using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoLettersRepository : Repository<OtoLetters> , IOtoLettersRepository
    {
        public OtoLettersRepository(DataContext context) : base(context)
        {
        }
    }
}
