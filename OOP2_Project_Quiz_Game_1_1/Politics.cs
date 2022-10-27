using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Politics : ICategory
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; } 
        
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

        public void GetAnswers(List<KeyValuePair<string,string>> answers)
        {
            foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answer = item.Value;
                }
            }
        }

        Question makeQuestion = new Question();
    }
}

