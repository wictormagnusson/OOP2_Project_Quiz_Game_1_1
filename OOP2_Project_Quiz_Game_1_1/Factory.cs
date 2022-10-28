using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        QDatabase database;

        public string _question { get; set; }
        public List<string> _alternatives { get; set; }
        public string _answer { get; set; }


        public Factory(QDatabase _database)
        {
            database = _database;
        }

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
                    Question questionObject = new Question(_question, _alternatives,_answer);
                    QuestionList.Add(questionObject);
                    break;

                /*    case "Geography":
                        Geography geography = new Geography();
                        _question = geography.GetQuestion(database.questions);
                        _alternatives = politics.GetAlternatives(database.alternatives);
                        _answer = politics.GetAnswer(database.answers);
                        Question questionObject = new Question(_question, _alternatives, _answer);
                        QuestionList.Add(questionObject);

                        return QuestionList;


                        return QuestionList.Add(new Geograpy geography());
                        break;

                    case "Sport":
                        return QuestionList.Add(new Sports sports());
                        break; */

                    default:
                        break;
                }              
            }
            return QuestionList;


        }
     
    }
}

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
