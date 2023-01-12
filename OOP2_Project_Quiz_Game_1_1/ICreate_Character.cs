using System;
namespace OOP2_Project_Quiz_Game_1_1
{
 

    public interface ICreate_Character
    {
        public Character character { get; set; }
        public Character Create_New_Character(int characterChoice);

    }
   

}

