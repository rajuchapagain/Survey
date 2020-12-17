using CompassSurvey.Models;


namespace CompassSurvey.Data.EFCore
{

    public class EfCoreQuestionRepository : EfCoreRepository<Question, CompassDbContext>
    {
        public EfCoreQuestionRepository(CompassDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
