using CompassSurvey.Data.EFCore;
using CompassSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompassSurvey.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : CompassDBController<Option, EfCoreOptionRepository>
    {
        public OptionsController(EfCoreOptionRepository repository) : base(repository)
        {

        }
    }
}
