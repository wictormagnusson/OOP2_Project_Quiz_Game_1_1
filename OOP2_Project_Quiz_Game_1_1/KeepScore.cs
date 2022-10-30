using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class KeepScore
    {
        public int CorrectAnswer { get; set; }
        public int Score { get; set; } = 0;

        public KeepScore()
        {

        }

        public int CheckAnswer(List<Question> questionList, int questionNo, int choice)
        {
            if (questionList[questionNo].Answer == questionList[questionNo].Alternatives[choice - 1])
            {
                Score++;
            }
     
            return Score;
        }

    }

}
