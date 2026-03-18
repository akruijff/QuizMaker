using System.Xml.Serialization;

namespace QuizMaker
{
    public class Persistence
    {
        public static void SaveQuiz(Quiz quiz)
        {
            using FileStream file = File.Create("quiz.xml");
            XmlSerializer serializer = new XmlSerializer(quiz.GetType());
            serializer.Serialize(file, quiz);
        }

        public static Quiz? ReadQuiz()
        {
            using FileStream file = File.OpenRead("quiz.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Quiz));
            return serializer.Deserialize(file) as Quiz;
        }
    }
}
