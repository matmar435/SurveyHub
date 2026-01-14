namespace SurveyHub.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int SurveyResponseId { get; set; }
        public int QuestionId { get; set; }

        public int? AnswerOptionId { get; set; }
        public string? TextAnswer { get; set; }

        public SurveyResponse SurveyResponse { get; set; }
    }

}
