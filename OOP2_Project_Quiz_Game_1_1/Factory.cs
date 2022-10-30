using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        public Politics NewPolitics { get; set; }
        public Factory(string category, Database database, int count)
        {
            if (category == "Politics")
            {
                NewPolitics = new Politics(database,count);
            }
        }

        // skapar listor av Categoryobjekts

        /*public Politics CreateCategory(string category,Database database)  //gör om till lamba expressions
        {

            if (category == "Politics")
            {
               NewPolitics = new Politics(database);
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
            }
            return NewPolitics;
        }*/
    }
}

