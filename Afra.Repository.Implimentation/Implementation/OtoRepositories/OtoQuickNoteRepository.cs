using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoQuickNoteRepository : Repository<OtoQuickNote> , IOtoQuickNoteRepository
    {
        public OtoQuickNoteRepository(DataContext context) : base(context)
        {
        }
    }
}
