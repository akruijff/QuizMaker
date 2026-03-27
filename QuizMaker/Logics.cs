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
    }
}
