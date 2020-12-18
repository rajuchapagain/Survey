using CompassSurvey.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompassSurvey.Models
{
    public class SurveyQuestionDto : IEntity
    {
        public SurveyQuestionDto()
        {
            Questions = new List<QuestionDto>();
        }

        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public List<QuestionDto> Questions { get; set; }

    }
}
