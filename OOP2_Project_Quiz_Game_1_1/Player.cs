using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string playerName)
        {
            Name = playerName;
            Score = 0;
        }
    }
}

