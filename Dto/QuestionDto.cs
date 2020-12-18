using CompassSurvey.Data;
using CompassSurvey.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompassSurvey.Models
{
    public class QuestionDto : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int QuestionType { get; set; }
        public List<OptionDto> Options { get; set; }
    }
}
