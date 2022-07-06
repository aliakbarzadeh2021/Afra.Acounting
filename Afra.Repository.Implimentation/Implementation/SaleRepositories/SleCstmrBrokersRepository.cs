using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCstmrBrokersRepository : Repository<SleCstmrBrokers> , ISleCstmrBrokersRepository
    {
        public SleCstmrBrokersRepository(DataContext context) : base(context)
        {
        }
    }
}
