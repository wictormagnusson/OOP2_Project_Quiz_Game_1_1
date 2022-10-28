using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Alternatives { get; set; }
        public string Answer { get; set; } 

        public Question(string _QuestionText, List<string> _Alternatives, string _Answer)
        {
            QuestionText = _QuestionText;
            Alternatives = _Alternatives;
            Answer = _Answer;
        }

    }
}

