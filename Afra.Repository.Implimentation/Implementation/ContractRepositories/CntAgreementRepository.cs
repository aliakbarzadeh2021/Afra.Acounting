using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAgreementRepository : Repository<CntAgreement> , ICntAgreementRepository
    {
        public CntAgreementRepository(DataContext context) : base(context)
        {
        }
    }
}
