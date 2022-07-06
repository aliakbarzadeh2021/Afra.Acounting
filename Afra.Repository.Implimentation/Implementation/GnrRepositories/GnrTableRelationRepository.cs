using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrTableRelationRepository : Repository<GnrTableRelation> , IGnrTableRelationRepository
    {
        public GnrTableRelationRepository(DataContext context) : base(context)
        {
        }
    }
}
