using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    // Generics med varians
    public interface ICategory <in Tin, in Tin2,in Tin3, out Tout>
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public List<Question> QuestionList { get; set; }  // creates a new list of questions
        public int counter { get; set; }
        public Tout GetValue(Tin inputList, Tin2 choice, Tin3 counter); // gets a specific value
    }
}

