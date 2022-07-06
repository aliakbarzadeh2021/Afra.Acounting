using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrSendItmRepository : Repository<CmrSendItm> , ICmrSendItmRepository
    {
        public CmrSendItmRepository(DataContext context) : base(context)
        {
        }
    }
}
