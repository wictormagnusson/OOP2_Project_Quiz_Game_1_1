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
        List<Question> questionList { get; set; } = new List<Question>();


        //  _QDatabase.questions; // Hämta ut questionslistan från databas
        //   _QDatabase.alternatives; // Hämta ut questionslistan från databas


        public Politics() // Ta emot tre listor ;questions, answers, alternatives
        {
            QDatabase _QDatabase = new QDatabase();

        }


        // Konstruktor som skapar lista av questionobjekt av typen Politics 
        public Politics(QDatabase database, int count)
        {

            for (int i = 0; i < count; i++)
            {
                questionText = GetQuestion(database.questions);
                alternativeText = GetAlternatives(database.alternatives);
                answerText = GetAnswer(database.answers);

                Question question = new Question(questionText,alternativeText,answerText);
                questionList.Add(question);
            }


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







        //ska denna kanske sortera våra databaslistor, och skapa listor av quesitonobjekt
        // ger att när man skapar ett politics objekt så kan man bara skapa nytt Politics och man får en lista av question
        //objekt av den typen man vill ha... allstå returnerar factory en lista av questionobjekt av vald kategori.

 /*       public List<Question> ListOfQuestions()
        {
            List<Question> questionList = new List<Question>();

            for (int i = 0; i < max; i++)
            {
                Question question = new Question(questionText, alternativeText, answerText);
                questionList.Add(question);
            }
           
            return questionList;
        }

       
        public Politics(QDatabase database)
        {
            makeQuestion = new Question(GetQuestion(database.questions), // 
            GetAlternatives(database.alternatives),
            GetAnswers(database.answers));
        }

        public Question MakeQuestion()
        {
            return makeQuestion;
        }
    }


} */