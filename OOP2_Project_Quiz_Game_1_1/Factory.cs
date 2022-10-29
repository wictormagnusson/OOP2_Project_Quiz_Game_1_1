using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        public Factory()
        {

        }

        // skapar listor av Categoryobjekts

        public List<Question> CreateCategory(string category,Database database)  //gör om till lamba expressions
        {
            List<Question> categoryList = new List<Question>();

            if (category == "Politics")
            {
                categoryList.Add(new Politics(database).MakeQuestion());
            }

            /*for (int i = 1; i < 10; i++)
            {
                var choice = category switch
                {
                    "Politics" => categoryList.Add(new Politics(database).MakeQuestion()),
                    "Geography" => "Geography", 
                    "Sports" => "Sports",
                    _ => "Invalid category!"
                };
            }*/
            return categoryList;
        }
    }
}

