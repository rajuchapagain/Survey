using CompassSurvey.Models;

namespace CompassSurvey.Data.EFCore
{
    public class EfCoreOptionRepository : EfCoreRepository<Option, CompassDbContext>
    {
        public EfCoreOptionRepository(CompassDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
