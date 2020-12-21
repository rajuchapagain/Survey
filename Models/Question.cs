using CompassSurvey.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CompassSurvey.Models
{
    public class Question : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int QuestionType { get; set; }
        public List<Option> Options { get; set; }

        [IgnoreDataMember]
        [ForeignKey("Survey")]
        public virtual int SurveyId { get; set; }
        [IgnoreDataMember]
        public virtual Survey Survey { get; set; }
    }
}
