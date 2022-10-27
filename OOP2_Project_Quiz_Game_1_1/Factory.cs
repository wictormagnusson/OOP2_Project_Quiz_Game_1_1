using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        QDatabase database;

        // skapar listor av Questionobjekts
        //

        public Factory(QDatabase _database)
        {
        }

        public ICategory CreateCategory(string category)
        {
            switch (category)
            {
                case Politics => new Politics;
                    default;
            }

        }
     
    }
}

