using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCstmrsRepository : Repository<SleCstmrs> , ISleCstmrsRepository
    {
        public SleCstmrsRepository(DataContext context) : base(context)
        {
        }
    }
}
