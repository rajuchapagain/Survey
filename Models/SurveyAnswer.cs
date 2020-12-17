using CompassSurvey.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompassSurvey.Models
{
    public class SurveyAnswer : IEntity
    {
        public int Id { get; set; } //submission Id
        public string SubmittedBy { get; set; } //Person who submitted the Survey
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public ICollection<Option> Options { get; set; }

        public Option SelectedOption { get; set; }
    }
}
