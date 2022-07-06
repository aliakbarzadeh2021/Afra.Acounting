using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ElementRolesRepository : Repository<ElementRoles> , IElementRolesRepository
    {
        public ElementRolesRepository(DataContext context) : base(context)
        {
        }
    }
}
