// See https://aka.ms/new-console-template for more information
using System;
    //OOP2_Project_Quiz_Game_1_1;
using System.Collections.Generic;
using OOP2_Project_Quiz_Game_1_1;



 //   Gameplay gameplay = new Gameplay();
    QDatabase QDatabase = new QDatabase(); // Skapa databasen 
  //  Player player = new Player(); // Skapa en player
    Factory factory = new Factory(QDatabase); // Skapa en Factory som tar emot databasen
    Menu menu = new Menu(); // Visar menu och frågar användare om kategori och antal frågor
    menu.showMenu();
   

List<Question> listOfQuestions = new List<Question>();

listOfQuestions= factory.CreateCategory(menu.inputString, menu.inputInt); // valet skickas till factory som gör lista av vald kategori

for (int i = 0; i < menu.inputInt; i++)
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

    

