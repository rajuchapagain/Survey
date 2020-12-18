using Microsoft.AspNetCore.Mvc;
using CompassSurvey.Models;
using CompassSurvey.Data.EFCore;
using System.Collections.Generic;

namespace CompassSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : CompassDBController<Survey, EfCoreSurveyRepository>
    {
        private EfCoreSurveyRepository _repository; 

        public SurveyController(EfCoreSurveyRepository repository) : base(repository)
        {
            _repository = repository; 

        }

    }

}
