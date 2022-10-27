using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        QDatabase database;

        

        public Factory(QDatabase _database)
        {
            database = _database;
        }

        // skapar en lista av Categoryobjekts givet val av användaren 
        //


        public ICategory CreateCategory(string category)  
        {
           
            List<ICategory> categoryList = new List<ICategory>();

            

            for (int i = 1; i < 10; i++)
            {
                switch (category)
                {
                    case "Politics":
                        return 
                        categoryList.Add(new Politics politics());
                        break;
                    case "Geography":
                        return categoryList.Add(new Geograpy geography());
                        break;

                case "Sport":
                        return categoryList.Add(new Sports sports());
                        break; 

                default:
                        break;
                }
            }
            

        }
     
    }
}

