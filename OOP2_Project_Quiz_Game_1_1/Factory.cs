using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
      public ICategory category { get; set; }
  
        public Factory(int categoryChoice, Database database, int count) // ta in en Icategory för abstrakt injektion...men hur? 
        {
            //Pattern matching
            ICategory choice = categoryChoice switch
            {
                1 => category = new Politics(database, count), // ändrat politics till category
                2 => category = new Music(database, count), // ändrat newmusic till category
                3 => category = new Geography(database, count), // ändrat newgeography till category

                _ => throw new ArgumentException("Invalid category!") 
            };
        }
    }
}

