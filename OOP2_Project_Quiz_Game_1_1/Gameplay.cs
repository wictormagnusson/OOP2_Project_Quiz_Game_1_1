using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Gameplay
    {
        //Flytta new av objekt hit? Eller skapa new i main men skicka in de objekten här 
        private string Title = "Welcome to the Quiz Game!";
        public int CategoryChoice { get; set; }
        public int CharacterChoice { get; set; }
        
        public Gameplay(ICategory<List<KeyValuePair<string, string>>, string, string> category, IPlayer player)
        {

        }

        /*
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
 */
        public void Play()
        {
            Console.WriteLine(Title);
           
            Console.WriteLine("\n");
        }
       
        public void PrintScore(int score, Character character)
        {
            Console.WriteLine("\nGreat job " + character.Name + "! You scored " + score + " points!");
            Console.ReadLine();
            //Environment.Exit(0);
        }
       
    }
}

