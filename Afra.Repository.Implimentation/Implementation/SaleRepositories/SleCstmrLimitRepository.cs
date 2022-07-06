using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCstmrLimitRepository : Repository<SleCstmrLimit> , ISleCstmrLimitRepository
    {
        public SleCstmrLimitRepository(DataContext context) : base(context)
        {
        }
    }
}
