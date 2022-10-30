using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class IterateOverQuestions
    {
        //TESTA att iterera över valda frågor..
        Factory factory;
        
        public IterateOverQuestions( Factory factory1)
        {
            factory = factory1;

            for (int i = 0; i <= factory.noQuestions; i++)
            {
                Console.WriteLine(factory.category);
            }

            //   List<Question> listOfQuestions = new List<Question>();

            //  factory1.CreateCategory(menu.inputString, menu.inputInt); // valet skickas till factory som gör lista av vald kategori


        }
    }
}

