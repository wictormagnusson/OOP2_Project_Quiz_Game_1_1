using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class DisplayQuestionlist
    {
        public int inputInt { get; set; }
        public int score { get; set; }
        public DisplayQuestionlist(List<Question> Qlist, KeepScore keepscore)
        {
            int questionCount = 1;

            foreach (var Question in Qlist)
            {
                int altCount = 1;
                Console.WriteLine($"\nQuestion {questionCount}: {Question.QuestionText}\n");

                foreach (var item in Question.Alternatives)
                {
                    Console.WriteLine($"Alternative {altCount}: {item}");
                    altCount++;
                }

                int input = Convert.ToInt32(Console.ReadLine());
                score = keepscore.CheckAnswer(Qlist, questionCount - 1, input);
                questionCount++;
                Console.WriteLine();
            }
        }
    }
}

