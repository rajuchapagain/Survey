using CompassSurvey.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompassSurvey.Models
{
    public class Option : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        
        [ForeignKey("Question")]
        public virtual int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
