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
        public Category(Database database, int count, string choice)
        {
            counter = newCategory.GetKeyIndex(database.questions, choice);
      
            //  GetValue is a method that gets the wanted value to be able to create Question objects to put in a QuestionList .
            // This QuestionList is created and used for the user to pick and answer questions of a specific category

            for (int i = 0; i < count; i++)
            {
                QuestionList.Add(new Question(GetValue(database.questions, choice, counter),   
                GetValue(database.alternatives, choice, counter),
                GetValue(database.answers, choice, counter)));
                counter++;
            }
        }

        public string GetValue(List<KeyValuePair<string, string>> inputList, string choice, int counter)
        {

            foreach (var item in inputList.Where(question => question.Key == choice && inputList.IndexOf(question) == counter)) 
            {
                question = item.Value;
            }
            return question;
        }

        public List<string> GetValue(List<KeyValuePair<string, List<string>>> inputList, string choice, int counter)
        {
            foreach (var item in inputList.Where(question => question.Key == choice && inputList.IndexOf(question) == counter)) 
            {
                alternative = item.Value;
            }
            return alternative;
        }
    }
}

