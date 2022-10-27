using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Politics : ICategory
    {
       
        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }


        Question _question = new Question(string questionText,List<string> alternativeText, string answerText)
        

        public Politics() // Ta emot tre listor ;questions, answers, alternatives
        {
        }

        /*       foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answer = item.Value;
                }
            } */

        public void GetQuestion(List<KeyValuePair<string, string>> questions)
            {
                foreach (var item in questions)
                {
                    if (item.Key == "Politics")
                    {
                        question = item.Value;
                    }
                }
            }
        public void GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives)
        {
            foreach (var item in alternatives)
            {
                if (item.Key == "Politics")
                {
                    alternative = item.Value;
                }
            }
        }
  
        
    }
}

