﻿using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    // kan vi göra vårt interface till generics?

    public interface ICategory <in Tin, in Tin2,out Tout>
    {
        public string question { get; set; }
        public List<string> alternative { get; set; }
        public string answer { get; set; }
        public List<Question> QuestionList { get; set; }
        //public int counter { get; set; }
        public Tout GetValue(Tin inputList, Tin2 choice);

        //public string GetQuestion(List<KeyValuePair<string, string>> objects);
        //public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives);
        //public string GetAnswers(List<KeyValuePair<string, string>> answers);
    }
}

