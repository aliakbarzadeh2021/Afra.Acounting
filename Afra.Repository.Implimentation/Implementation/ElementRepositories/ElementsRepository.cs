using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ElementsRepository : Repository<Elements> , IElementsRepository
    {
        public ElementsRepository(DataContext context) : base(context)
        {
        }
    }
}
