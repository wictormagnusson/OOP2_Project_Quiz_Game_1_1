using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Alternatives { get; set; }
        public string Answer { get; set; }

        public Question(string questionText, List<string> alternatives, string answer)
        {
            QuestionText = questionText;
            Alternatives = alternatives;
            Answer = answer;
        } 
    }
}

