using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBrokersRepository : Repository<SleBrokers> , ISleBrokersRepository
    {
        public SleBrokersRepository(DataContext context) : base(context)
        {
        }
    }
}
