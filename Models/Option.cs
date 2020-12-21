using CompassSurvey.Data;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CompassSurvey.Models
{
    public class Option : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        [IgnoreDataMember]
        public virtual Question Question { get; set; }
    }
}
