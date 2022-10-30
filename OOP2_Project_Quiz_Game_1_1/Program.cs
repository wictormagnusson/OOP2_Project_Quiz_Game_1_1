using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;

Gameplay gameplay = new Gameplay();
Database database = new Database();
KeepScore keepscore = new KeepScore();
gameplay.Play();
gameplay.ChooseCategory();
Factory factory = new Factory(gameplay.Category, database, 4);

//DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(factory.NewPolitics.QuestionList, keepscore);
DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(factory.NewGeography.QuestionList, keepscore);
//DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(factory.NewMusic.QuestionList, keepscore);

gameplay.PrintScore(displayQuestionList.score);