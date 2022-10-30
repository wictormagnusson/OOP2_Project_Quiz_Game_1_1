using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class DisplayQuestionlist
    {
        public DisplayQuestionlist(List<Question> Qlist)
        {
            int questionCount = 1;

            foreach (var Question in Qlist)
            {
                int altCount = 1;
                Console.WriteLine($"Question {questionCount}: {Question.QuestionText}");
                foreach (var item in Question.Alternatives)
                {

                    Console.WriteLine($"Alternative {altCount}: {item}");
                    altCount++;
                }
                Console.WriteLine("Correct answer: " + Question.Answer);
                questionCount++;
                Console.WriteLine();
            }
        }
    }
}

