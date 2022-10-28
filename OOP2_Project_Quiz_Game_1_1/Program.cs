// See https://aka.ms/new-console-template for more information
using System;
    //OOP2_Project_Quiz_Game_1_1;
using System.Collections.Generic;
using OOP2_Project_Quiz_Game_1_1;



 //   Gameplay gameplay = new Gameplay();
    QDatabase QDatabase = new QDatabase(); // Skapa databasen 
  //  Player player = new Player(); // Skapa en player
    Factory factory = new Factory(QDatabase); // Skapa en Factory som tar emot databasen

    Console.WriteLine("Please choose category:\nPolitics\nSports\nGeography\n"); //Uppdatera och lägg i egen klass
    string inputString = Console.ReadLine()!; // användaren väljer kategori
    Console.WriteLine("Please choose number of questions 1-10"); //Uppdatera och lägg i egen klass
    int inputInt;
    int.TryParse(Console.ReadLine(), out inputInt);
Console.WriteLine(inputInt);

List<Question> listOfQuestions = new List<Question>();

listOfQuestions= factory.CreateCategory(inputString, inputInt); // valet skickas till factory som gör lista av vald kategori

for (int i = 0; i < inputInt; i++)
{
    Console.WriteLine(listOfQuestions[i]);
}



    // Oklart vart vi ska skapa frågan...
    /*    Question _question = new Question(ICategory.GetQuestion(QDatabase.questions), ICategory.GetAlternatives(QDatabase.alternatives)), ICategory.GetAnswer(QDatabase.answers));
        _question.QuestionText = ICategory.GetQuestion(QDatabase.questions);
        _question.Alternatives = ICategory.GetAlternatives(QDatabase.alternatives);
        _question.Answer = ICategory.GetAnswer(QDatabase.answers);


    ICategory que = ICategory.GetQuestion();
    que.GetAlternatives();
    que.GetAnswer();

    // for(int i=1; i<10; i++) {}

    //Det Görkem skrev 
    que = ICategory.GetQuestion();
        que.GetAlternatives();
        que.GetAnswer();


   */

    // Politics politics = new Politics();


