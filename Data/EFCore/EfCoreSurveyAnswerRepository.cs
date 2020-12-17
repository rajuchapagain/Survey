using CompassSurvey.Models;

namespace CompassSurvey.Data.EFCore
{
    public class EfCoreSurveyAnswerRepository : EfCoreRepository<SurveyAnswer, CompassDbContext>
    {
        public EfCoreSurveyAnswerRepository(CompassDbContext context) : base(context)
        {

        }

        // We can add new methods specific to the movie repository here in the future
    }
}
