using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Create_Questions
    {
      public ICategory<List<KeyValuePair<string, string>>, string, int, string> category { get; set; }
  
        public Create_Questions(int categoryChoice, Database database, int count) // ta in en Icategory för abstrakt injektion...men hur? 
        {
            //Pattern matching
            ICategory<List<KeyValuePair<string, string>>, string, int, string> choice = categoryChoice switch
            {
                1 => category = new Specific_Category(database, count, "Politics"), // ändrat politics till category
                2 => category = new Specific_Category(database, count, "Geography"), // ändrat newmusic till category
                3 => category = new Specific_Category(database, count, "Music"), // ändrat newgeography till category

                _ => throw new ArgumentException("Invalid category!") 
            };
        }
    }
}

