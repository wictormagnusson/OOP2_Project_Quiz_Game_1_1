using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;

Gameplay gameplay = new Gameplay();
gameplay.Play();
            //Database database = new Database();
            //Politics politics = new Politics(database.questions, database.answers, database.alternatives);
            //Console.WriteLine("Question: " + politics.question);
            //Console.WriteLine("Alternatives: " + printList(politics.alternative) + " ");
            //Console.WriteLine("Answer: " + politics.answer);

string printList(List<string> hej)
{
    string output = "";
    foreach (var item in hej)
    {
        output += item + " | ";
    }
    return output;
}