using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayUserFieldRepository : Repository<PayUserField> , IPayUserFieldRepository
    {
        public PayUserFieldRepository(DataContext context) : base(context)
        {
        }
    }
}
