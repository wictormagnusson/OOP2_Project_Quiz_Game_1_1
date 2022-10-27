// See https://aka.ms/new-console-template for more information
using System;
    //OOP2_Project_Quiz_Game_1_1;
using System.Collections.Generic;
using OOP2_Project_Quiz_Game_1_1;


static void Main(string[] args)
{
 //   Console.WriteLine("HEj jag är Elsas branch");
 //   QDatabase database = new QDatabase();
 //   Gameplay gameplay = new Gameplay();



    QDatabase QDatabase = new QDatabase(); // Skapa databasen 
    Player player = new Player(); // Skapa en player
    Factory factory = new Factory(QDatabase); // Skapa en Factory som tar emot databasen

    Console.WriteLine("Please choose category:\nPolitics\nSports\nGeography\n"); //Uppdatera och lägg i egen klass
    string input = Console.ReadLine()!; // användaren väljer kategori

    factory.CreateCategory(input); // valet skickas till factory som gör lista av vald kategori



    
        Question _question = new Question;
        _question.QuestionText = ICategory.GetQuestion(QDatabase.questions);
        _question.Alternatives = ICategory.GetAlternatives(QDatabase.alternatives);
        _question.Answer = ICategory.GetAnswer(QDatabase.answers);


        // for(int i=1; i<10; i++) {}
        que = ICategory.GetQuesiton();
        que.GetAlternatives();
        que.GetAnswer();

    


    // Politics politics = new Politics();
}

