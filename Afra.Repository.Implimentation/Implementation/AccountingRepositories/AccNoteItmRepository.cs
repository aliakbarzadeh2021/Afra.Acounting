using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccNoteItmRepository : Repository<AccNoteItm> , IAccNoteItmRepository
    {
        public AccNoteItmRepository(DataContext context) : base(context)
        {
        }
    }
}
