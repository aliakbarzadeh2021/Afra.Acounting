using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleDebCreHdrRepository : Repository<SleDebCreHdr> , ISleDebCreHdrRepository
    {
        public SleDebCreHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
