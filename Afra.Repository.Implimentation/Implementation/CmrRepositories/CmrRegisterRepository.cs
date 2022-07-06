using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrRegisterRepository : Repository<CmrRegister> , ICmrRegisterRepository
    {
        public CmrRegisterRepository(DataContext context) : base(context)
        {
        }
    }
}
