using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class KeepScore
    {
        public string CorrectAnswer { get; set; }
        public int Score { get; set; } = 0;

        public KeepScore()
        {

        }

        public int ChecAnswer(List<Question> questionList, int questionNo, string answer)
        {
            CorrectAnswer = questionList[questionNo].Answer;
            if (answer == CorrectAnswer)
            {
                Score++;
            }
            return Score;
        }
    }

}
