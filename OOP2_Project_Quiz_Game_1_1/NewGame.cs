using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class NewGame
    {
        public int CategoryChoice { get; set; }
        public int CharacterChoice { get; set; }


        public NewGame()
        {
            ChooseCharacter();
            ChooseCategory();
        }

        public void ChooseCategory()
        {
            Console.WriteLine("To play the game, please choose category 1-3:");
            Console.WriteLine("1: Politics | 2: Geography | 3: Music");
            CategoryChoice = Convert.ToInt32(Console.ReadLine());

            //  Category = Console.ReadLine();
        }

        public void ChooseCharacter()
        {
            Console.WriteLine("Choose your character:");
            Console.WriteLine("1: TeddyBear | 2: BuzzLightYear | 3: Unicorn | 4: Random character");
            CharacterChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

    
    }
}

