using CompassSurvey.Data;
using System.Collections.Generic;

namespace CompassSurvey.Models
{
    public class SurveyQuestion : IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
