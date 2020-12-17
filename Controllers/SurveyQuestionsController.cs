using Microsoft.AspNetCore.Mvc;
using CompassSurvey.Models;
using CompassSurvey.Data.EFCore;

namespace CompassSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyQuestionsController : CompassDBController<SurveyQuestion, EfCoreSurveyQuestionRepository>
    {
        public SurveyQuestionsController(EfCoreSurveyQuestionRepository repository) : base(repository)
        {

        }
    }

}
