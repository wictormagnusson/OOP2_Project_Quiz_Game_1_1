using System;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Specific_Category : Category
    {
        //Konstruktor
        public Specific_Category(Database database, int count, string choice)
        {
          counter = newCategory.GetKeyIndex(database.questions, choice);
            
            for (int i = 0; i < count; i++)
            {
                QuestionList.Add(new Question(GetValue(database.questions, choice, counter),
                GetValue(database.alternatives, choice, counter),
                GetValue(database.answers, choice, counter)));
                counter++;
            }
        }
    }
}

