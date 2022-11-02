using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Specific_Category : Category
    {
        //Konstruktor
        public Specific_Category(Database database, int count, string choice)
        {
            for (int i = 0; i < count; i++)
            {
                QuestionList.Add(new Question(GetValue(database.questions, choice),
                GetValue(database.alternatives, choice),
                GetValue(database.answers, choice)));
                newCategory.indexNo++;
            }
        }
    }
}

