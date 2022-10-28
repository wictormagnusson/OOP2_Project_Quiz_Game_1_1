using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    // filtrering av information i databas givet kategori

    // Göra om till en ISort

    public class Politics : ICategory
    {
       
        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }

        QDatabase _QDatabase = new QDatabase();
      //  _QDatabase.questions; // Hämta ut questionslistan från databas
     //   _QDatabase.alternatives; // Hämta ut questionslistan från databas

        public Politics() // Ta emot tre listor ;questions, answers, alternatives
        {

        }
       

        public string GetQuestion(List<KeyValuePair<string, string>> questions) // Byta till databasobjektlista
            {
                foreach (var item in questions)
                {
                    if (item.Key == "Politics")
                    {
                    questionText = item.Value;
                    }
                }
            return questionText;
            }
        public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives) // Byta till databasobjektlista
        {
            foreach (var item in alternatives)
            {
                if (item.Key == "Politics")
                {
                     alternativeText = item.Value;
                }
            }
            return alternativeText;
        }


        public string GetAnswer(List<KeyValuePair<string, string>> answers) // Byta till databasobjektlista
        {
            foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answerText = item.Value;
                }
            }
            return answerText;
        }
     

    }
}

