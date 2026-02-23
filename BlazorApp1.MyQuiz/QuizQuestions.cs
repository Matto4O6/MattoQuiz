namespace BlazorApp1.MyQuiz
{
    public class QuizQuestions
    {
        public string Question { get; set; }
        // 4 multiple choice format for answers
        public List<string> Options { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
