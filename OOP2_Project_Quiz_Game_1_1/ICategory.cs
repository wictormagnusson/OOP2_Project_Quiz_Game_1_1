using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public interface ICategory
    {
        public string GetQuestion(List<KeyValuePair<string, string>> questions);
        public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives);
        public string GetAnswers(List<KeyValuePair<string, string>> answers);
    }
}

