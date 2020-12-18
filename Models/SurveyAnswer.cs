using CompassSurvey.Data;
using System.ComponentModel.DataAnnotations;

namespace CompassSurvey.Models
{
    public class SurveyAnswer : IEntity
    {
        [Key]
        public int Id { get; set; } //submission Id
        public string SubmittedBy { get; set; } //Person who submitted the Survey
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
    }
}
