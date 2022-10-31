using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Gameplay
    {
        //Flytta new av objekt hit? Eller skapa new i main men skicka in de objekten här 
        private string Title = "Welcome to the Quiz Game!";
    //    public string Category { get; set; } // Byta till objekt av category

        public int CatergoryChoice { get; set; }

        public Gameplay()
        {

        }

        public void ChooseCategory()
        {
            Console.WriteLine("To play the game, please choose category 1-3:");
            Console.WriteLine("1: Politics | 2: Music | 3: Geography");
            CatergoryChoice = Convert.ToInt32(Console.ReadLine());
            
          //  Category = Console.ReadLine();
        }

        public void Play()
        {
            Console.WriteLine(Title);
            Console.Write("\nType in your name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("\n");
            Player CurrentPlayer = new Player(nameInput);
            Console.WriteLine("Welcome " + CurrentPlayer.Name + "!\n");
        }

        public void PrintScore(int score)
        {
            Console.WriteLine("\nGood job! You scored " + score + " points!");
            Console.ReadLine();
            //Environment.Exit(0);
        }
       
    }
}

