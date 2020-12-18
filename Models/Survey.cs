using CompassSurvey.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompassSurvey.Models
{
    public class Survey : IEntity
    {
        public Survey()
        {
            Questions = new List<Question>();
        }

        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public List<Question> Questions { get; set; }

    }
}
