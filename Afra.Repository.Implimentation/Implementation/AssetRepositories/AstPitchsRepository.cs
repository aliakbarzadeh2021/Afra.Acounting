using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstPitchsRepository : Repository<AstPitchs> , IAstPitchsRepository
    {
        public AstPitchsRepository(DataContext context) : base(context)
        {
        }
    }
}
