using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayVchDetInfsRepository : Repository<PayVchDetInfs> , IPayVchDetInfsRepository
    {
        public PayVchDetInfsRepository(DataContext context) : base(context)
        {
        }
    }
}
