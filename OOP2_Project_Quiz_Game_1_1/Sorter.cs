/*using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Sorter : ICategory
        // Möjligt sätt att hantera alla alternativ till, minskar duplicering av kod--> dock tar det bort anledningen till factorry så då måste vi byta till typ bridge..
        // då får vi ha typ gameplay som interface och göra konkreta klasser som har Icategorys som reference. har en 
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public int counter { get; set; } = 0; // Hårdkodning
        public List<Question> QuestionList { get; set; } = new List<Question>();

        public Sorter(Database database, int count)
        {
            for (int i = 0; i < count; i++)
            {
                QuestionList.Add(new Question(GetQuestion(database.questions),
                GetAlternatives(database.alternatives),
                GetAnswers(database.answers)));
                counter++;
            }
        }

        public string GetQuestion(List<KeyValuePair<string, string>> questions)
        {
            for (int i = counter; i < questions.Count; i++)
            {
                if (questions[i].Key == "Politics")
                {
                    question = questions[i].Value;
                    return question;
                }
                if (questions[i].Key == "Music")
                {
                    question = questions[i].Value;
                    return question;
                }
                if (questions[i].Key == "Geography")
                {
                    question = questions[i].Value;
                    return question;
                }
            }
            return question;
        }

        public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives)
        {
            for (int i = counter; i < alternatives.Count; i++)
            {
                if (alternatives[i].Key == "Politics")
                {
                    alternative = alternatives[i].Value;
                    return alternative;
                }
                if (alternatives[i].Key == "Music")
                {
                    alternative = alternatives[i].Value;
                    return alternative;
                }
                if (alternatives[i].Key == "Geography")
                {
                    alternative = alternatives[i].Value;
                    return alternative;
                }
            }
            return alternative;
        }

        public string GetAnswers(List<KeyValuePair<string, string>> answers)
        {
            for (int i = counter; i < answers.Count; i++)
            {
                if (answers[i].Key == "Politics")
                {
                    answer = answers[i].Value;
                    return answer;
                }
                if (answers[i].Key == "Music")
                {
                    answer = answers[i].Value;
                    return answer;
                }
                if (answers[i].Key == "Geography")
                {
                    answer = answers[i].Value;
                    return answer;
                }
            }
            return answer;
        }

      
        }
    }*/

