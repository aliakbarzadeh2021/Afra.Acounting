using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoLttrLabelsRepository : Repository<OtoLttrLabels> , IOtoLttrLabelsRepository
    {
        public OtoLttrLabelsRepository(DataContext context) : base(context)
        {
        }
    }
}
