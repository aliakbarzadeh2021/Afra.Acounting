using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleTaxesRepository : Repository<SleTaxes> , ISleTaxesRepository
    {
        public SleTaxesRepository(DataContext context) : base(context)
        {
        }
    }
}
