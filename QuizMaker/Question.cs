namespace QuizMaker
{
    public class Question(string text)
    {
        public string Text { get; } = text;
        private HashSet<Answer> _answers = [];

        public override bool Equals(object? obj) => obj is Question other ? Text == other.Text : false;
        public override int GetHashCode() => Text?.GetHashCode() ?? 0;
        public void Add(Answer anwser) => _answers.Add(anwser);
    }
}
