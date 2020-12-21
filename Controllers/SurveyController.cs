using Microsoft.AspNetCore.Mvc;
using CompassSurvey.Models;
using CompassSurvey.Data.EFCore;

namespace CompassSurvey.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SurveyController : CompassDBController<Survey, EfCoreSurveyRepository>
    {
        private EfCoreSurveyRepository _repository;

        public SurveyController(EfCoreSurveyRepository repository) : base(repository)
        {
            //only initialize to perform other functions in the repository
            _repository = repository;

        }

    }

}
