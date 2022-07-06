using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFContractDetRepository : Repository<TrsFContractDet> , ITrsFContractDetRepository
    {
        public TrsFContractDetRepository(DataContext context) : base(context)
        {
        }
    }
}
