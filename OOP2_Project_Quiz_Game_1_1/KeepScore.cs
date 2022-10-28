using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    //Ta in svar från användaren
    //Checka mot rätt answer (svar) givet Lista av QuestionObjekt från Factory


    public class KeepScore // KOllar om användaren väljer rätt svar och ger i så fall poäng via Score. 
    {

        public int Score { get; set; }
        private string CorrectAnswer { get; set; }
        QDatabase qDatabase = new QDatabase();
         

        public KeepScore()
        {
            Score = 0;
            CorrectAnswer = "";
        }

        public int CheckAnswer(List<Question> questionList, int questionNo, string InputAnswer)
        {
            CorrectAnswer = questionList[questionNo].Answer;

            if (InputAnswer == CorrectAnswer)
            {
                Score++;
            }
            return Score;
        }

        /*  public int CheckAnswer(string InputAnswer )

          {
              if (InputAnswer == CorrectAnswer)
              {
                  Score++;
              }
              return Score;

          }


          public string ExtractAnswer(List<Question> questionList, int questionNo)
          {
              CorrectAnswer = questionList[QuestionNo].Answer;
              return CorrectAnswer;

          }

          */


    }
}

