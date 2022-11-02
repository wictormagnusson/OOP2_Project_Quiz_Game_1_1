using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Character : IPlayer
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Legs { get; set; }
        public int Score { get; set; }

        public Character()
        {

        } 

        public Character random(List<Character> input)
        {
            var random = new Random();
            int index = random.Next(input.Count);
            Character output = input[index];
            return output;
        }

        public class Unicorn : Character
        {
            public Unicorn(string name, string color, int legs)
            {
                Name = name;
                Color = color;
                Legs = legs;
            }
        }

        public class BuzzLightYear : Character
        {
            public BuzzLightYear(string name, string color, int legs)
            {
                Name = name;
                Color = color;
                Legs = legs;
            }
        }

        public class Teddybear : Character
        {
            public Teddybear(string name, string color, int legs)
            {
                Name = name;
                Color = color;
                Legs = legs;
            }
        }
    }
}

