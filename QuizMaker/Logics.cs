namespace QuizMaker
{
    public class Logics
    {
        public static bool IsAllCorrect(List<Answer> answers)
        {
            bool allCorrect = false;
            foreach (Answer a in answers)
                if (a.IsAnswerCorrect)
                    allCorrect = true;
            return allCorrect;
        }

        public static double CalcuateScore(List<Answer> answers, List<int> choices)
        {
            double score = 0;
            foreach (int i in choices)
                score += answers[i].Score;
            return score;
        }
    }
}
