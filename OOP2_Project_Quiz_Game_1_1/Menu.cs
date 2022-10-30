using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Menu
    {
        public string inputString { get; set; }
        public int inputInt { get; set; }

        public Menu()
        {
            Console.WriteLine("Please choose category:\nPolitics\nGeography\nMusic"); //Uppdatera och lägg i egen klass
            inputString = Console.ReadLine()!; // användaren väljer kategori
            Console.WriteLine(inputString); //TEST
            Console.WriteLine("Please choose number of questions 1-10"); //Uppdatera och lägg i egen klass
          //  int inputInt;
            int.TryParse(Console.ReadLine(), out int inputInt);
            Console.WriteLine(inputInt); //TEST
        }

        public void showMenu()
        {
           

        }

    }
}

