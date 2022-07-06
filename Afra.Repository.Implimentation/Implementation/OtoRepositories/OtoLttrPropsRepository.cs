using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoLttrPropsRepository : Repository<OtoLttrProps> , IOtoLttrPropsRepository
    {
        public OtoLttrPropsRepository(DataContext context) : base(context)
        {
        }
    }
}
