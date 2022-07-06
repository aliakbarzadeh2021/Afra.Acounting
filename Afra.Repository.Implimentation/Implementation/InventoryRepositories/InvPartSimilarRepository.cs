using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartSimilarRepository : Repository<InvPartSimilar> , IInvPartSimilarRepository
    {
        public InvPartSimilarRepository(DataContext context) : base(context)
        {
        }
    }
}
