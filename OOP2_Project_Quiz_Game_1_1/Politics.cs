using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Politics : ICategory
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public int counter { get; } = 0;

        Question makeQuestion;

        public string GetQuestion(List<KeyValuePair<string, string>> questions)
        {
            for (int i = counter; i < questions.Count; i++)
            {
                if (questions[i].Key == "Politics")
                {
                    question = questions[i].Value;
                }
            }
            /*foreach (var item in questions)
            {
                if (item.Key == "Politics")
                {
                    question = item.Value;
                }
            }*/
            return question;
        }

        public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives)
        {
            for (int i = counter; i < alternatives.Count; i++)
            {
                if (alternatives[i].Key == "Politics")
                {
                    alternative = alternatives[i].Value;
                }
            }
            /*foreach (var item in alternatives)
            {
                if (item.Key == "Politics")
                {
                    alternative = item.Value;
                }
            }*/
            return alternative;
        }

        public string GetAnswers(List<KeyValuePair<string, string>> answers)
        {
            for (int i = counter; i < answers.Count; i++)
            {
                if (answers[i].Key == "Politics")
                {
                    answer = answers[i].Value;
                }
            }
            /*foreach (var item in answers)
            {
                if (item.Key == "Politics")
                {
                    answer = item.Value;
                }
            }*/
            return answer;
        }

        public Politics(Database database)
        {
            makeQuestion = new Question(GetQuestion(database.questions),
            GetAlternatives(database.alternatives),
            GetAnswers(database.answers));
        }

        public Question MakeQuestion()
        {
            return makeQuestion;
        }
    }
}

