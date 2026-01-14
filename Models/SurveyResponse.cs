namespace SurveyHub.Models
{
    public class SurveyResponse
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public DateTime SubmittedAt { get; set; }

        public Survey Survey { get; set; }
        public List<Answer> Answers { get; set; }
    }

}
