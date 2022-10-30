using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;

Gameplay gameplay = new Gameplay();
Database database = new Database();
gameplay.Play();
gameplay.ChooseCategory();
Factory factory = new Factory(gameplay.Category, database, 4);
DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(factory.NewPolitics.QuestionList);



/*string printList(List<string> hej)
{
    string output = "";
    foreach (var item in hej)
    {
        output += item + " | ";
    }
    return output;}*/
