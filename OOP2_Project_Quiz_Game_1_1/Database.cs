using System;
using System.Collections.Generic;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Database
    {
        public List<KeyValuePair<string, string>> questions { get; set; } = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, string>> answers { get; set; } = new List<KeyValuePair<string, string>>();
        public List<KeyValuePair<string, List<string>>> alternatives { get; set; } = new List<KeyValuePair<string, List<string>>>();

        public Database()
        {
            questions.Add(new KeyValuePair<string, string>("Politics", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Politics", "Who is the prime minister of United Kingdom?"));
            questions.Add(new KeyValuePair<string, string>("Politics", "Who is the president France?"));
            questions.Add(new KeyValuePair<string, string>("Politics", "Who is the chancellor of Germany?"));
            questions.Add(new KeyValuePair<string, string>("Sports", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Sports", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Sports", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Sports", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Geography", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Geography", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Geography", "Who is the prime minister of Sweden?"));
            questions.Add(new KeyValuePair<string, string>("Geography", "Who is the prime minister of Sweden?"));

     
            answers.Add(new KeyValuePair<string, string>("Politics","Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Politics", "Rishi Sunak"));
            answers.Add(new KeyValuePair<string, string>("Politics", "Emmanuel Macron"));
            answers.Add(new KeyValuePair<string, string>("Politics", "Olaf Scholz"));

            answers.Add(new KeyValuePair<string, string>("Sports", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Sports", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Sports", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Sports", "Ulf Kristersson"));

            answers.Add(new KeyValuePair<string, string>("Geography", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Geography", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Geography", "Ulf Kristersson"));
            answers.Add(new KeyValuePair<string, string>("Geography", "Ulf Kristersson"));

            List<string> q1 = new List<string>();
            q1.Add("Magdalena Andersson");
            q1.Add("Fredrik Reinfeldt");
            q1.Add("Göran Persson");
            q1.Add("Ulf Kristersson");

            List<string> q2 = new List<string>();
            q2.Add("Liz Truss");
            q2.Add("Boris Johnson");
            q2.Add("Rishi Sunak");
            q2.Add("Tony Blair");

            List<string> q3 = new List<string>();
            q3.Add("Jagues Chirac");
            q3.Add("Nicolas Sarkozy");
            q3.Add("Francois Hollande");
            q3.Add("Emmanuel Macron");

            List<string> q4 = new List<string>();
            q4.Add("Angela Merkel");
            q4.Add("Olaf Scholz");
            q4.Add("Gerhard Schröder");
            q4.Add("Helmut Kohl");

            alternatives.Add(new KeyValuePair<string, List<string>>("Politics", q1));
            alternatives.Add(new KeyValuePair<string, List<string>>("Politics", q2));
            alternatives.Add(new KeyValuePair<string, List<string>>("Politics", q3));
            alternatives.Add(new KeyValuePair<string, List<string>>("Politics", q4));

                /* new KeyValuePair<string,string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),*/
            
          

        }
    }
}