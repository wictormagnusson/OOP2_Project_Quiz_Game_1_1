using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Category : ICategory<List<KeyValuePair<string, string>>, string, int, string>
    {
        public Counter newCategory  { get; set; } = new Counter();
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public int counter { get; set; }
        public List<Question> QuestionList { get; set; } = new List<Question>();
        
        //Konstruktor
        public Category()
        {

        }

        public string GetValue(List<KeyValuePair<string, string>> inputList, string choice, int counter)
        {

            foreach (var item in inputList.Where(question => question.Key == choice && inputList.IndexOf(question) == counter)) // Ska lösa en counter som fungerar så att alla frågor visas
            {
                question = item.Value;
            }
            return question;
        }

        public List<string> GetValue(List<KeyValuePair<string, List<string>>> inputList, string choice, int counter)
        {
            foreach (var item in inputList.Where(question => question.Key == choice && inputList.IndexOf(question) == counter))// Ska lösa en counter som fungerar så att alla frågor visas
            {
                alternative = item.Value;
            }
            return alternative;
        }
    }
}

