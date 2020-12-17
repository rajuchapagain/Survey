using CompassSurvey.Models;

namespace CompassSurvey.Data.EFCore
{
    public class EfCoreSurveyQuestionRepository : EfCoreRepository<SurveyQuestion, CompassDbContext>
    {
        public EfCoreSurveyQuestionRepository(CompassDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
