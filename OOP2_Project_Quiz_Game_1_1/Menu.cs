using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Menu
    {
        public string inputString { get; set; }
        public int inputInt { get; set; }

        public Menu()
        {
            Console.WriteLine("Please choose category:\nPolitics\nSports\nGeography\n"); //Uppdatera och lägg i egen klass
            string inputString = Console.ReadLine()!; // användaren väljer kategori
            Console.WriteLine("Please choose number of questions 1-10"); //Uppdatera och lägg i egen klass
            int inputInt;
            int.TryParse(Console.ReadLine(), out inputInt);
            Console.WriteLine(inputInt);
        }

        public void showMenu()
        {
           

        }

    }
}

