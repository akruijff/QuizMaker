using System.Xml.Serialization;

namespace QuizMaker
{
    public class Persistence
    {
        public static void SaveQuiz(Quiz quiz, string file)
        {
            using FileStream f = File.Create(file);
            XmlSerializer serializer = new XmlSerializer(quiz.GetType());
            serializer.Serialize(f, quiz);
        }

        public static Quiz? ReadQuiz(string file)
        {
            using FileStream f = File.OpenRead(file);
            XmlSerializer serializer = new XmlSerializer(typeof(Quiz));
            return serializer.Deserialize(f) as Quiz;
        }
    }
}
