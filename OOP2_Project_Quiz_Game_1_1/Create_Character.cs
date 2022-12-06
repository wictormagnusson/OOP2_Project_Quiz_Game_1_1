using System;
using static OOP2_Project_Quiz_Game_1_1.Character;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Create_Character : Character
    {
        public Character character { get; set; }

        public Create_Character()
        {   
        }

        // Factory pattern och pattern matching
        public Character Create_New_Character(int characterChoice)
        {
            Character newCharacter = characterChoice switch
            {
                1 => character = new TeddyBear("BabyTeddyBear", "sunny yellow", 4, "Teddy Bear"),
                2 => character = new BuzzLightYear("BabyBuzzLightYear", "space gray", 2, "Buzz LightYear"),
                3 => character = new Unicorn("BabyUnicorn", "magic purple", 4, "Unicorn"),
                _ => throw new ArgumentException("Invalid character!")
            };
            return character;
        }
    }
}

