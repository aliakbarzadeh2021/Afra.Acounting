using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFundBillHdrRepository : Repository<TrsFundBillHdr> , ITrsFundBillHdrRepository
    {
        public TrsFundBillHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
