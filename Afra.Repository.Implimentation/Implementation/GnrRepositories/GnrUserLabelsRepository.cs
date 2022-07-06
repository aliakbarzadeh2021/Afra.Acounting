using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserLabelsRepository : Repository<GnrUserLabels> , IGnrUserLabelsRepository
    {
        public GnrUserLabelsRepository(DataContext context) : base(context)
        {
        }
    }
}
