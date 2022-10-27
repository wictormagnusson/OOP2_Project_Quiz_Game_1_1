using System;
using System.Collections.Generic;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Gameplay
    {
        QDatabase QDatabase = new QDatabase();
        Player player = new Player();
        Factory factory = new Factory();

        public Gameplay()
        {
            
        }

     
            // for(int i=1; i<10; i++) {}
            que = ICategory.GetQuesiton();
            que.GetAlternatives();
            que.GetAnswer();


        public void NewGame(Player player, ICategory category)
        {

        }

    }
}

