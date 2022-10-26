using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Politics : ICategory
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }

        public Politics(List<KeyValuePair<string, string>> questions, List<KeyValuePair<string, string>> answers, List<KeyValuePair<string, List<string>>> alternatives)
        {
            foreach (var item in questions)
            {
                if (item.Key == "Politics")
                {
                    question = item.Value;
                }
            }

            foreach (var item in alternatives)
            {
                if (item.Key == "Politics")
                {
                    alternative = item.Value;
                }
            }

            foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answer = item.Value;
                }
            }
        }
    }
}

