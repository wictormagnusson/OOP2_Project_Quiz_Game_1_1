﻿using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Geography: ICategory
    {
        public Geography()
        {
            QDatabase _QDatabase = new QDatabase();

        }

        public string questionText { get; set; }
        public string answerText { get; set; }
        public List<string> alternativeText { get; set; }

        //  _QDatabase.questions; // Hämta ut questionslistan från databas
        //   _QDatabase.alternatives; // Hämta ut questionslistan från databas

        public string GetQuestion(List<KeyValuePair<string, string>> questions) // Byta till databasobjektlista
        {
            foreach (var item in questions)
            {
                if (item.Key == "Geography")
                {
                    questionText = item.Value;
                }
            }
            return questionText;
        }
        public List<string> GetAlternatives(List<KeyValuePair<string, List<string>>> alternatives) // Byta till databasobjektlista
        {
            foreach (var item in alternatives)
            {
                if (item.Key == "Geography")
                {
                    alternativeText = item.Value;
                }
            }
            return alternativeText;
        }

        public string GetAnswer(List<KeyValuePair<string, string>> answers) // Byta till databasobjektlista
        {
            foreach (var item in answers)
            {
                if (item.Key == "Geography")
                {
                    answerText = item.Value;
                }
            }
            return answerText;
        }



    }

}

