using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;

Gameplay gameplay = new Gameplay();
Database database = new Database();
Factory factory = new Factory();
List<Question> questionDisplay = new List<Question>();
gameplay.Play();
gameplay.ChooseCategory();
questionDisplay = factory.CreateCategory(gameplay.Category, database);

foreach (var Question in questionDisplay)
{
    Console.WriteLine("Question 1: " + Question.QuestionText);

    foreach (var item in Question.Alternatives)
    {
        Console.WriteLine("Alternative: " + item);
    }

    Console.WriteLine("Correct answer: "+Question.Answer);
}


/*string printList(List<string> hej)
{
    string output = "";
    foreach (var item in hej)
    {
        output += item + " | ";
    }
    return output;}*/
