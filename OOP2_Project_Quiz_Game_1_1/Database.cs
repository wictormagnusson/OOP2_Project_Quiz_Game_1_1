using System;
using System.Collections.Generic;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class Database
    {

        public Database()
        {
            public List<KeyValuePair<string, string>> questions = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string,string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Politics","Who is the prime minister of United Kingdom?"),
                 new KeyValuePair<string,string>("Politics","Who is the president France?"),
                 new KeyValuePair<string,string>("Politics","Who is the chancellor of Germany?"),

                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),

                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?")
            };

        public List<KeyValuePair<string, string>> answers = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string,string>("Politics","Ulf Kristersson"),
                 new KeyValuePair<string,string>("Politics","Rishi Sunak"),
                 new KeyValuePair<string,string>("Politics","Emmanuel Macron"),
                 new KeyValuePair<string,string>("Politics","Olaf Scholz"),

                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),

                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?")
            };

        List<string> q1 = new List<string>();

        q1.Add("Magdalena Ansersson");
            q1.Add("Fredrik Reinfeldt");
            q1.Add("Göran Persson");
            q1.Add("Ulf Kristersson");

            List<string> q2 = new List<string>();
        q1.Add("Liz Truss");
            q1.Add("Boris Johnson");
            q1.Add("Rishi Sunak");
            q1.Add("Tony Blair");

            List<string> q3 = new List<string>();
         q1.Add("Jagues Chirac");
            q1.Add("Nicolas Sarkozy");
            q1.Add("Francois Hollande");
            q1.Add("Emmanuel Macron");

            List<string> q4 = new List<string>();
            q1.Add("Angela Merkel");
            q1.Add("Olaf Scholz");
            q1.Add("Gerhard Schröder");
            q1.Add("Helmut Kohl");

            public List<KeyValuePair<string, List<string>>> alternatives = new List<KeyValuePair<string, List<string>>>()
            {
                 new KeyValuePair<string, List<string>>("Politics",q1),
                 new KeyValuePair<string, List<string>>("Politics",q2),
                 new KeyValuePair<string, List<string>>("Politics",q3),
                 new KeyValuePair<string, List<string>>("Politics",q4)

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
            };
    }
    

    }
}

