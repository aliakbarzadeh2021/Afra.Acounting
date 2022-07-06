using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrTrsRqstBankInfRepository : Repository<UsrTrsRqstBankInf> , IUsrTrsRqstBankInfRepository
    {
        public UsrTrsRqstBankInfRepository(DataContext context) : base(context)
        {
        }
    }
}
