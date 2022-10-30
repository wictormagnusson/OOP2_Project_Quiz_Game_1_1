using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    //Ta in svar från användaren
    //Checka mot rätt answer (svar) givet Lista av QuestionObjekt från Factory


    public class KeepScore // KOllar om användaren väljer rätt svar och ger i så fall poäng via Score. 
    {

        public int Score { get; set; }
       // private string CorrectAnswer { get; set; } // Byta till int
        private int CorrectAnswer { get; set; } // Byta till int

        QDatabase qDatabase = new QDatabase();
         

        public KeepScore()
        {
            Score = 0;
            CorrectAnswer = 0;
        }

        // INPUT ANSWER MÅSTE VI BYTA TILL ATT DET ÄR SIFFROR, KOMMER BLI SÅ SVÅRT ANNARS
        public int CheckAnswer(List<Question> questionList, int questionNo, int InputAnswer)
        {

            if (questionList[questionNo] == questionList[questionNo].Alternatives[InputAnswer - 1])

            {
                Score++;
            }


            }

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

