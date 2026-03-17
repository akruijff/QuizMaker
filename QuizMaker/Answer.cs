namespace QuizMaker
{
    public class Answer(string text)
    {
        public string Text { get; } = text;
        public bool IsAnswerCorrect { get; set; }
        public double Score { get; set; }

        public override bool Equals(object? obj) => obj is Answer other ? Text == other.Text : false;
        public override int GetHashCode() => Text?.GetHashCode() ?? 0;
        public override string ToString() => $"{Text} correct={IsAnswerCorrect} score={Score}";
    }
}
