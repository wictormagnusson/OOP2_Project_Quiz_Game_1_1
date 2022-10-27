using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Gameplay
    {
        private string Title = "Welcome to the Quiz Game!";
        private Player CurrentPlayer;

        public Gameplay()
        {

        }

        public void Play()
        {
            Console.WriteLine(Title);
            Console.Write("Type in your name: ");
            CurrentPlayer.Name = Console.ReadLine();

        }
    }
}

