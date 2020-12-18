using CompassSurvey.Data;
using System.ComponentModel.DataAnnotations;

namespace CompassSurvey.Models
{
    public class Option : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public virtual Question Question { get; set; }
    }
}
