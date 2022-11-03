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

        public Gameplay(Character character, int score)
        {
            Display(character);
        }

        public void Display (Character character)
        {
            Console.WriteLine($"Your character is a {character.Color} {character.Type} with {character.Legs} legs that is called {character.Name}.");
            Console.WriteLine("Good Luck!");
            Console.WriteLine();
        }

        public void PrintScore(int score, Character character)
        {
            Console.WriteLine("\nGreat job " + character.Name + "! You scored " + score + " points!");
            Console.ReadLine();
        }
       
    }
}

