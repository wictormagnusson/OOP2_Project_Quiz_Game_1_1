using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public interface ICategory
    {
        public void GetQuestion(List<KeyValuePair<string, string>> questions);
        public void GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives);
   
    }
}

