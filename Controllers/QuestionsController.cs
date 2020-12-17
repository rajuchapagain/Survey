using Microsoft.AspNetCore.Mvc;
using CompassSurvey.Models;
using CompassSurvey.Data.EFCore;

namespace CompassSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : CompassDBController<Question, EfCoreQuestionRepository>
    {
        public QuestionsController(EfCoreQuestionRepository repository) : base(repository)
        {

        }
    }



}
