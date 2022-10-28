using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class KeepScore
    {
        public int Score { get; set; }
        private string CorrectAnswer { get; set; }

        public KeepScore()
        {
            Score = 0;
            CorrectAnswer = "";
        }

        public int CheckAnswer(string InputAnswer )

        {
            if (InputAnswer == CorrectAnswer)
            {
                Score++;
            }
            return Score;

        }
    }
}

