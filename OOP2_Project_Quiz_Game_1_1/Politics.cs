using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    // filtrerar information i databaslistor givet vald kategori

    // hur blir det om politics returnerar listor med objekt sorterade på kategori

    public class Politics : ICategory
    {      
        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }

        //  _QDatabase.questions; // Hämta ut questionslistan från databas
        //   _QDatabase.alternatives; // Hämta ut questionslistan från databas


        public Politics() // Ta emot tre listor ;questions, answers, alternatives
        {
            QDatabase _QDatabase = new QDatabase();
            
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

    /*  
       public List<Question> ListOfQuestions()
    {
        List<Question> questionList = new List<Question>();
        Question question = new Question(questionText, alternativeText, answerText);
        questionList.Add(question);
        return questionList;
    }   
    */

}