namespace QuizMaker
{
    public class Quiz
    {
        public HashSet<Question> Questions { get; private set; } = [];

        public void Add(Question question) => Questions.Add(question);
    }
}
