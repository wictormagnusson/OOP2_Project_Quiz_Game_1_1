using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Factory
    {
        QDatabase database;

        

        public Factory(QDatabase _database)
        {
        }

        // skapar listor av Categoryobjekts
        //


        public ICategory CreateCategory(string category)  //gör om till lamba expressions
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

