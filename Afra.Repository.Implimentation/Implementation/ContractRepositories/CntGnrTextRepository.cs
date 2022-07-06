using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntGnrTextRepository : Repository<CntGnrText> , ICntGnrTextRepository
    {
        public CntGnrTextRepository(DataContext context) : base(context)
        {
        }
    }
}
