using System;
using System.Collections.Generic;

using OOP2_Project_Quiz_Game_1_1;

Gameplay gameplay = new Gameplay();
Database database = new Database();
KeepScore keepscore = new KeepScore();
gameplay.Play();
gameplay.ChooseCategory();
Factory factory = new Factory(gameplay.CatergoryChoice, database, 4); // ändra till att ta emot ett category objekt istället för string som val av kategori

DisplayQuestionlist displayQuestionList = new DisplayQuestionlist(factory.category.QuestionList, keepscore);
gameplay.PrintScore(displayQuestionList.score);
