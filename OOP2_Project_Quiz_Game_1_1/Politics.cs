/*using System;
using System.Collections.Generic;
using System.Linq;
namespace OOP2_Project_Quiz_Game_1_1
{

    public class Politics : ICategory <List<KeyValuePair<string, string>>, string>
    {

        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public int counter { get; set; } = 0; // Hårdkodning
        public List<Question> QuestionList { get; set; } = new List<Question>();

        //Konstruktor
        public Politics(Database database, int count) // lägga till string category parameter istället för att hårdkoda kategori
        {
            for (int i = 0; i < count; i++)
            {
                QuestionList.Add(new Question(GetValue(database.questions), 
                GetValue(database.alternatives),
                GetValue(database.answers)));
                counter++;
            }
        }

        public string GetValue(List<KeyValuePair<string, string>> inputList)
        {
            foreach (var item in inputList.Where(question => question.Key == "Politics" && inputList.IndexOf(question) == counter))
            {
                question = item.Value;
            }
            return question;
        }

        public List<string> GetValue(List<KeyValuePair<string, List<string>>> inputList)
        {
            foreach (var item in inputList.Where(question => question.Key == "Politics" && inputList.IndexOf(question) == counter))
            {
                alternative = item.Value;
            }
            return alternative;
        }




        /*public string GetQuestion(List<KeyValuePair<string,string>> questions)
        {
            // lambda
            foreach (var item in questions.Where(question => question.Key == "Politics" && questions.IndexOf(question) == counter))
            {
                question = item.Value;
            }
            return question;
        }*/

        /*public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives)
        {
            for (int i = counter; i < alternatives.Count; i++)
            {
                if (alternatives[i].Key == "Politics")
                {
                    alternative = alternatives[i].Value;
                    return alternative;
                }
            }
            return alternative;
        }*/

        /*public string GetAnswers(List<KeyValuePair<string, string>> answers)
        {
            for (int i = counter; i < answers.Count; i++)
            {
                if (answers[i].Key == "Politics")
                {
                    answer = answers[i].Value;
                    return answer;
                }
            }
            return answer;
        }   
    }
}*/

