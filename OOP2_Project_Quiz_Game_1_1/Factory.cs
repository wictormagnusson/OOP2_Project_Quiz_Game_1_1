using System;
using System.Collections.Generic;
using OOP2_Project_Quiz_Game_1_1;
//using Internal;
//using Internal;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        QDatabase database;
        public int noQuestions { get; set; }


        public ICategory category { get; set; }
        public Politics politics { get; set; }
        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }




        // Skapar Objekt av vald kategori
        public Factory(QDatabase _database)
        {
            database = _database;
        }

        public Factory(QDatabase _database, string categoryChoice, int numberOfQuestions) // Ge tillbaka en lista av objekt
        {
            database = _database;
            noQuestions = numberOfQuestions;

            switch (categoryChoice)
            {
                case "Politics":
                    politics = new Politics(_database, numberOfQuestions);
                    
                    break;

                case "Geography":
                    category = new Geography(); // ska uppdateras
                    break;
                case "Music":
                    category = new Music(); // ska uppdateras
                    break;
                default:
                    break;

            }
        }
    }
}


        // skapar en lista av Questionobjekts givet kategorival och antal frågor av användaren 
/*   public List<Question> CreateCategory(string categoryChoice, int numberOfQuestions)
   {

       List<Question> QuestionList = new List<Question>();

       for (int i = 1; i < numberOfQuestions; i++)
       {
           switch (categoryChoice)
           {
               case "Politics":
                   Politics politics = new Politics();
                   _question = politics.GetQuestion(database.questions);

                   _alternatives = politics.GetAlternatives(database.alternatives);
                   _answer = politics.GetAnswer(database.answers);
                   Question questionObjectPol = new Question(_question, _alternatives, _answer);
                   QuestionList.Add(questionObjectPol);


                   break;

               case "Geography":
                   Geography geography = new Geography();
                   _question = geography.GetQuestion(database.questions);
                   _alternatives = geography.GetAlternatives(database.alternatives);
                   _answer = geography.GetAnswer(database.answers);
                   Question questionObjectGeo = new Question(_question, _alternatives, _answer);
                   QuestionList.Add(questionObjectGeo);


                   break;
               /*
                                   case "Sport":
                                       return QuestionList.Add(new Sports sports());
                                       break; 

               default:
                   break;
           }
       }

       Console.WriteLine(_question);


       return QuestionList;


   }

}





}
 */

/*    for (int i = 1; i < 10; i++)
               {
                   switch (category)
                   {
                       case "Politics":
                           return
                           categoryList.Add(new Politics politics());
                           break;
                       case "Geography":
                           return categoryList.Add(new Geograpy geography());
                           break;

                       case "Sport":
                           return categoryList.Add(new Sports sports());
                           break;

                       default:
                           break;
                   }
               }

            */


/*
 * 
 *   public string _question { get; set; }
        public List<string> _alternatives { get; set; }
        public string _answer { get; set; }
 * 
 * 
 // skapar en lista av Questionobjekts givet kategorival och antal frågor av användaren 
    public List<Question> CreateCategory(string categoryChoice, int numberOfQuestions)
{

    List<Question> QuestionList = new List<Question>();

    for (int i = 1; i < numberOfQuestions; i++)
    {
        switch (categoryChoice)
        {
            case "Politics":
                Politics politics = new Politics();
                _question = politics.GetQuestion(database.questions);

                _alternatives = politics.GetAlternatives(database.alternatives);
                _answer = politics.GetAnswer(database.answers);
                Question questionObjectPol = new Question(_question, _alternatives, _answer);
                QuestionList.Add(questionObjectPol);


                break;

            case "Geography":
                Geography geography = new Geography();
                _question = geography.GetQuestion(database.questions);
                _alternatives = geography.GetAlternatives(database.alternatives);
                _answer = geography.GetAnswer(database.answers);
                Question questionObjectGeo = new Question(_question, _alternatives, _answer);
                QuestionList.Add(questionObjectGeo);


                break;
            /*
                                case "Sport":
                                    return QuestionList.Add(new Sports sports());
                                    break; 

            default:
                break;
        }
    }

    Console.WriteLine(_question);


    return QuestionList;


} */