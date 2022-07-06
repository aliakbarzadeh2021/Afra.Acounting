using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrExhibitionRqstRepository : Repository<UsrExhibitionRqst> , IUsrExhibitionRqstRepository
    {
        public UsrExhibitionRqstRepository(DataContext context) : base(context)
        {
        }
    }
}
