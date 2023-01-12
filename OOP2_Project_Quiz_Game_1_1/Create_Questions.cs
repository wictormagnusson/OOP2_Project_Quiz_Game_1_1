using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Create_Questions
    {
      public ICategory<List<KeyValuePair<string, string>>, string, int, string> category { get; set; }
  
        public Create_Questions(int categoryChoice, Database database, int count) 
        {
            //Pattern matching
            ICategory<List<KeyValuePair<string, string>>, string, int, string> choice = categoryChoice switch
            {
                1 => category = new Category(database, count, "Politics"),
                2 => category = new Category(database, count, "Geography"), 
                3 => category = new Category(database, count, "Music"), 

                _ => throw new ArgumentException("Invalid category!") 
            };
        }
    }
}

