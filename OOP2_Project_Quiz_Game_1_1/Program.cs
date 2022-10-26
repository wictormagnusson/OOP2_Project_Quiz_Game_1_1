<<<<<<< Updated upstream
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Hello, Santa!");
Console.WriteLine("Hello summer 2023");
=======
﻿using System;
// See https://aka.ms/new-console-template for more information
/*namespace OOP2_Project_Quiz_Game_1_1
{
    class Program
    {
        static void Main(string[] args)
        {*/
            Database database = new Database();
            Politics politics = new Politics(database.questions, database.answers, database.alternatives);
            Console.WriteLine("Question: " + politics.question);
            Console.WriteLine("Alternatives: " + politics.alternative);
            Console.WriteLine("Answer:" + politics.answer);
        /*}
    }
}*/
>>>>>>> Stashed changes
