using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserFormsRepository : Repository<GnrUserForms> , IGnrUserFormsRepository
    {
        public GnrUserFormsRepository(DataContext context) : base(context)
        {
        }
    }
}
