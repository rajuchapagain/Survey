using CompassSurvey.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace CompassSurvey.Data.EFCore
{
    public class EfCoreSurveyRepository : EfCoreRepository<Survey, CompassDbContext>
    {
        public EfCoreSurveyRepository(CompassDbContext context) : base(context)
        {

        }

       ///This is example of how to pull nested objects, but implemented extension class to include the nested object and used inside 
        //public List<Survey> GetAllSurvey()
        //{
        //    return this.context.SurveyQuestion.Include(r => r.Questions)
        //            .ThenInclude(s => s.Options).ToList();
        //}
    }
}
