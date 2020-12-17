using CompassSurvey.Data;

namespace CompassSurvey.Models
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Question Question { get; set; }
    }
}
