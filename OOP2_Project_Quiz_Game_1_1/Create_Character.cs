using System;
using static OOP2_Project_Quiz_Game_1_1.Character;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Create_Character : Character
    {
        public Character character { get; set; }
        public Random rnd { get; set; } = new Random();
        public Create_Character(int characterChoice)
        {
            //Pattern matching
            Character newCharacter = characterChoice switch
            {
                1 => character = new TeddyBear("BabyTeddyBear", "Sunny Yellow", 4, "TeddyBear"),
                2 => character =  new BuzzLightYear("BabyBuzzLightYear", "Space Gray", 2, "BuzzLightYear"), 
                3 => character = new Unicorn("BabyUnicorn", "Magic Purple", 4, "Unicorn") , 
                //4 =>  Tänker att man kan randomise tillbaka till 1-3 istället för att skapa en färdig objektlista att randomise över. Överkurs?
                _ => throw new ArgumentException("Invalid character!")
            };
            
        }
    }
}

