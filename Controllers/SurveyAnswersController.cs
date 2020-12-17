using Microsoft.AspNetCore.Mvc;
using CompassSurvey.Models;
using CompassSurvey.Data.EFCore;

namespace CompassSurvey.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class SurveyAnswersController : CompassDBController<SurveyAnswer, EfCoreSurveyAnswerRepository>
    {
        public SurveyAnswersController(EfCoreSurveyAnswerRepository repository) : base(repository)
        {

        }
    }
}

