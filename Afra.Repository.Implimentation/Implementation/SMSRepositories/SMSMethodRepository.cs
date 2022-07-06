using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SMSMethodRepository : Repository<SMSMethod> , ISMSMethodRepository
    {
        public SMSMethodRepository(DataContext context) : base(context)
        {
        }
    }
}
