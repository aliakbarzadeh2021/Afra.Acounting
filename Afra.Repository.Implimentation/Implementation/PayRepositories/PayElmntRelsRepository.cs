using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayElmntRelsRepository : Repository<PayElmntRels> , IPayElmntRelsRepository
    {
        public PayElmntRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
