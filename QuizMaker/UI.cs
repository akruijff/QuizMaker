namespace QuizMaker
{
    public class UI
    {
        public static void ShowQuizRequred() => Console.WriteLine("There is no quiz stored. Please enter a quiz first.");

        public static void DisplayScore(double score)
        {
            Console.WriteLine("FIN");
            Console.WriteLine($"You're score is: {score}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue to the menu");
            Console.ReadKey(true);
            Console.WriteLine();
        }

        public static void DisplayQuestion(Question question, int questionNumer, int totalNumberQuestions)
        {
            Console.WriteLine($"Question {questionNumer} / {totalNumberQuestions}:");
            Console.WriteLine(question.Text);
            Console.WriteLine();
        }

        public static List<Answer> DisplayOptions(List<Answer> answers)
        {
            Console.WriteLine($"You have {answers.Count} options:");
            for (int i = 1; i <= answers.Count; ++i)
                Console.WriteLine($"{i}: {answers[i - 1].Text}");
            return answers;
        }

        public static List<int> ReadOptions()
        {
            Console.Write("Please pick (one or mutilple by typing multiple numers): ");
            string? s = Console.ReadLine();
            Console.WriteLine();

            if (s == null || s == "")
                return [];

            List<int> choices = new();
            foreach (char c in s)
                if (int.TryParse(c.ToString(), out int result))
                    choices.Add(c);
            return choices;
        }

        public static void ProcessPlayerChoice(List<Answer> answers, List<int> choices, bool allIncorrect)
        {
            if (choices.Count == 0)
            {
                if (allIncorrect)
                    Console.WriteLine("You're right; all answers are incorrect.");
                else
                    Console.Write("There are correct answers!");
            }
            else
            {
                Console.WriteLine("You choose:");
                foreach (int i in choices)
                {
                    string result = answers[i].IsAnswerCorrect ? "And it's a correct answer" : "But it's a wrong anwser";
                    double points = answers[i].Score;
                    Console.WriteLine($"{i + 1} - {answers[i].Text}");
                    Console.WriteLine($"{result} - points: {points}");
                }
            }
            Console.WriteLine();
        }

        public static Question? ReadQuestion()
        {
            string? s = Console.ReadLine();
            return s is null or "" ? null : new Question(s);
        }

        public static Answer? ReadAwnser()
        {
            string? s = Console.ReadLine();
            return s is null or "" ? null : new Answer(s);
        }

        public static bool ReadBool()
        {
            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'Y' or 'y': return true;
                    case 'N' or 'n': return false;
                }
            }
        }

        public static double ReadDouble()
        {
            while (true)
            {
                string? s = Console.ReadLine();
                if (double.TryParse(s, out double result))
                    return result;
            }
        }
    }
}
