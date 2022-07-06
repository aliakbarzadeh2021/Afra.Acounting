using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayRepListsRepository : Repository<PayRepLists> , IPayRepListsRepository
    {
        public PayRepListsRepository(DataContext context) : base(context)
        {
        }
    }
}
