using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine()!;
            Score = 0;
        }
        
    }
}

