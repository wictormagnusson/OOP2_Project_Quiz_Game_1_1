using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        public ICategory category { get; set; }
        public Politics NewPolitics { get; set; }
        public Geography NewGeography { get; set; }
        public Music NewMusic { get; set; }

        public Factory(string category, Database database, int count)
        {
            ICategory choice = category switch
            {
                "Politics" => NewPolitics = new Politics(database, count),
                "Music" => NewMusic = new Music(database, count),
                "Geography" => NewGeography = new Geography(database, count),

                _ => throw new ArgumentException("Invalid category!")
            };
        }
    }
}

