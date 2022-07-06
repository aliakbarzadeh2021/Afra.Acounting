using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntFormFieldsRepository : Repository<CntFormFields> , ICntFormFieldsRepository
    {
        public CntFormFieldsRepository(DataContext context) : base(context)
        {
        }
    }
}
