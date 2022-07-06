using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SlePlacesRepository : Repository<SlePlaces> , ISlePlacesRepository
    {
        public SlePlacesRepository(DataContext context) : base(context)
        {
        }
    }
}
