using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Gameplay
    {
        private string Title = "Welcome to the Quiz Game!";
        public string Category { get; set; }

        public Gameplay()
        {

        }

        public void ChooseCategory()
        {
            Console.WriteLine("Please choose category: ");
            Console.WriteLine("Politics | Music | Geography");
            Category = Console.ReadLine();
        }

        public void Play()
        {
            Console.WriteLine(Title);
            Console.Write("Type in your name: ");
            string nameInput = Console.ReadLine();
            Player CurrentPlayer = new Player(nameInput);
            Console.WriteLine("Welcome " + CurrentPlayer.Name + "!");
        }

        public void PrintScore(int score)
        {
            Console.WriteLine("You scored " + score + " points!");
            Console.ReadLine();
        }
       
    }
}

