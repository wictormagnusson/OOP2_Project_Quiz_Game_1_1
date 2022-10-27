using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    // filtrering av information givet kategori

    public class Politics : ICategory
    {
       
        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }
        QDatabase _QDatabase = new QDatabase();

        Question QuestionObject = new Question(questionText, answerText, alternativeText);

        

        public Politics() // Ta emot tre listor ;questions, answers, alternatives
        {

        }
       

        public void GetQuestion(List<KeyValuePair<string, string>> questions)
            {
                foreach (var item in questions)
                {
                    if (item.Key == "Politics")
                    {
                    questionText = item.Value;
                    }
                }
            }
        public void GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives)
        {
            foreach (var item in alternatives)
            {
                if (item.Key == "Politics")
                {
                    alternativeText = item.Value;
                }
            }
        }


        public void GetAnswer(List<KeyValuePair<string, string>> answers)
        {
            foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answerText = item.Value;
                }
            }
        }
        //Här vill vi skapa question objekt givet information från listor?? 
        public void WholeQuestion()
        {
            Question _question = new Question(GetQuestion, GetAlternatives, GetAnswer);

        }

    }
}

