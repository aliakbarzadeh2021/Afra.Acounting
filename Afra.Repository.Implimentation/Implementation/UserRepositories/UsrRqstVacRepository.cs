using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrRqstVacRepository : Repository<UsrRqstVac> , IUsrRqstVacRepository
    {
        public UsrRqstVacRepository(DataContext context) : base(context)
        {
        }
    }
}
