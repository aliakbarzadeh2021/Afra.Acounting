using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccNoteHdrRepository : Repository<AccNoteHdr> , IAccNoteHdrRepository
    {
        public AccNoteHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
