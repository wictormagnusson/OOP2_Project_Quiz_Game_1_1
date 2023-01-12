using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;
using static OOP2_Project_Quiz_Game_1_1.Character;

Menu menu = new Menu();
Database database = new Database();
KeepScore keepscore = new KeepScore();
Create_Character createCharacter = new Create_Character();
createCharacter.Create_New_Character(menu.CharacterChoice);
Gameplay gameplay = new Gameplay(createCharacter.character, keepscore.Score);
Create_Questions createQuestions = new Create_Questions(menu.CategoryChoice, database, 4);
DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(createQuestions.category.QuestionList, keepscore);
gameplay.PrintScore(displayQuestionList.score, createCharacter.character);
