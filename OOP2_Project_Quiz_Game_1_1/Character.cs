using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public abstract class Character : IPlayer
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Legs { get; set; }
        public int Score { get; set; }
        public string Type { get; set; }

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
            public Unicorn(string name, string color, int legs, string type)
            {
                Name = name;
                Color = color;
                Legs = legs;
                Type = type;
            }
        }

        public class BuzzLightYear : Character
        {
            public BuzzLightYear(string name, string color, int legs, string type)
            {
                Name = name;
                Color = color;
                Legs = legs;
                Type = type;
            }
        }

        public class TeddyBear : Character
        {
            public TeddyBear(string name, string color, int legs, string type)
            {
                Name = name;
                Color = color;
                Legs = legs;
                Type = type;
            }
        }
    }
}

