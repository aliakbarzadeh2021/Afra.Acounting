using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleServicesRepository : Repository<SleServices> , ISleServicesRepository
    {
        public SleServicesRepository(DataContext context) : base(context)
        {
        }
    }
}
