using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GeoPosRepository : Repository<GeoPos> , IGeoPosRepository
    {
        public GeoPosRepository(DataContext context) : base(context)
        {
        }
    }
}
