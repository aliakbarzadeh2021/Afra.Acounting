using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleTaxDefValRepository : Repository<SleTaxDefVal> , ISleTaxDefValRepository
    {
        public SleTaxDefValRepository(DataContext context) : base(context)
        {
        }
    }
}
