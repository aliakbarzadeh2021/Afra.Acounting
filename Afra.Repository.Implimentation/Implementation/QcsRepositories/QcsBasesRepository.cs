using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsBasesRepository : Repository<QcsBases> , IQcsBasesRepository
    {
        public QcsBasesRepository(DataContext context) : base(context)
        {
        }
    }
}
