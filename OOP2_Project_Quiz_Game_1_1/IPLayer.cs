using System;
namespace OOP2_Project_Quiz_Game_1_1
{

    public interface IPlayer
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Legs { get; set; }
        public int Score { get; set; }
    }
}

