using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;
using static OOP2_Project_Quiz_Game_1_1.Character;

NewGame newGame1 = new NewGame();


Database databaseElsa = new Database();
KeepScore keepscoreElsa = new KeepScore();

//Elsa 
Create_Questions createQuestions1 = new Create_Questions(newGame1.CategoryChoice, databaseElsa, 4); // ändra till att ta emot ett category objekt istället för string som val av kategori
Create_Character createCharacter1 = new Create_Character(newGame1.CharacterChoice);

// I parametern där det står ICategory vill jag skicka in create_quesitons som returnerar en specik lista givet val från användaren
// I parametern där det står IPlayer vill jag skicka in creatCharacter som returnerar en specifik karaktär
// Givet att vi skapar createQuesitons här i main och skickar in det objektet i en plats som vill ha abstraktghet borde lösa abstrakt injektion

//----------------hur klassen ser ut-----------------------------//
//-----Gameplay gameplayElsa = new Gameplay(IPlayer player, ICategory category); --------------------


//hur det ser ut i main 

Gameplay gameplayElsa = new Gameplay( createQuestions1, createCharacter1);


gameplay.DisplayQuestions();
gameplay.PrintScore(keepscoreElsa, createCharacter1);







DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(createQuestions.category.QuestionList, keepscore); // Vill ha i gameplay

gameplay.PrintScore(displayQuestionList.score, createCharacter1);

// FÖRSÖKER SKAPA NÅGOT SOM I 79 I THEOBJKETORIENTEDWAY - ABSTRACT INJECTED OBJECT COMPOSITION



//----------------------------------------------------------------------------------------------------------------------------//
//Wictor 
Gameplay gameplay = new Gameplay(); 
Database database = new Database();
KeepScore keepscore = new KeepScore();
gameplay.Play();
gameplay.ChooseCategory();
Create_Questions createQuestions = new Create_Questions(gameplay.CategoryChoice, database, 4); // ändra till att ta emot ett category objekt istället för string som val av kategori
Create_Character createCharacter = new Create_Character(gameplay.CharacterChoice);

DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(createQuestions.category.QuestionList, keepscore);
gameplay.PrintScore(displayQuestionList.score, createCharacter.character);