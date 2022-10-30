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

            questions = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Great Britain?"),
                 new KeyValuePair<string, string>("Politics","Who is the president of France?"),
                 new KeyValuePair<string, string>("Politics","Who is the Kansler of Germany?"),

                 new KeyValuePair<string, string>("Geography","What is the fourth biggest city of Sweden?"),
                 new KeyValuePair<string, string>("Geography","What country has the biggest population in Europe?"),
                 new KeyValuePair<string, string>("Geography","What is the capital of Spain?"),
                 new KeyValuePair<string, string>("Geography","What is the capital of Greece?"),

                 new KeyValuePair<string, string>("Music","Who wrote the big hit ...Baby One More Time?"),
                 new KeyValuePair<string, string>("Music","Who wrote the big hit Poker Face?"),
                 new KeyValuePair<string, string>("Music","Who wrote the big hit Bohemian Raphsody?"),
                 new KeyValuePair<string, string>("Music","Who wrote the big hit Levels?")

            };

            answers = new List<KeyValuePair<string, string>>() // ÄNDRA TILL NUMMER
            {
                 new KeyValuePair<string,string>("Politics","Ulf Kristersson"),
                 new KeyValuePair<string,string>("Politics","Rishi Sunak"),
                 new KeyValuePair<string,string>("Politics","Emanuel Macron"),
                 new KeyValuePair<string,string>("Politics","Olaf Shoiz"),

                 new KeyValuePair<string,string>("Geography","Uppsala"),
                 new KeyValuePair<string,string>("Geography","Germany"),
                 new KeyValuePair<string,string>("Geography","Madrid"),
                 new KeyValuePair<string,string>("Geography","Athens"),

                 new KeyValuePair<string,string>("Music","Max Martin"),
                 new KeyValuePair<string,string>("Music","Lady Gaga and Red One"),
                 new KeyValuePair<string,string>("Music","Freddie Mercury"),
                 new KeyValuePair<string,string>("Music","Ash Purnouri, Etta James, Leroy Kirkland, Pearl Woods and Tim Bergling")

            };

            // Alternativ Politics



            List<string> q1 = new List<string>();
            q1.Add("Magdalena Andersson");
            q1.Add("Ulf Kristersson");
            q1.Add("Stefan Löfven");
            q1.Add("Fredrik Reinfeldt");

            List<string> q2 = new List<string>();
            q2.Add("Boris Johnson");
            q2.Add("Liz Truss");
            q2.Add("Rishi Sunak");
            q2.Add("Tony Blair");

            List<string> q3 = new List<string>();
            q3.Add("Emanuel Macron");
            q3.Add("Jacques Chirac");
            q3.Add("Nicolas Sorkozy");
            q3.Add("Francois Hollande");

            List<string> q4 = new List<string>();
            q4.Add("Olaf Shoiz");
            q4.Add("Angela Merkel");
            q4.Add("Gerhard Schröder");
            q4.Add("Helmut Kohl");


            //Alternativ Geography

            List<string> q5 = new List<string>();
            q5.Add("Uppsala");
            q5.Add("Kalmar");
            q5.Add("Helsingborg");
            q5.Add("Umeå");

            List<string> q6 = new List<string>();
            q6.Add("Germany");
            q6.Add("France");
            q6.Add("Italy");
            q6.Add("Spain");

            List<string> q7 = new List<string>();
            q7.Add("Barcelona");
            q7.Add("Madrid");
            q7.Add("Malaga");
            q7.Add("Valencia");

            List<string> q8 = new List<string>();
            q8.Add("Tessanoliki");
            q8.Add("Athens");
            q8.Add("Kalamata");
            q8.Add("Hellas");


            //Alternatives Music

            List<string> q9 = new List<string>();
            q9.Add("Max Martin");
            q9.Add("Martin Maxus");
            q9.Add("Shellback");
            q9.Add("Jörgen Elofsson");

            List<string> q10 = new List<string>();
            q10.Add("Red One");
            q10.Add("Lady Gaga and Shellback ");
            q10.Add("Jörgen Elofsson");
            q10.Add("Lady Gaga and Red One");

            List<string> q11 = new List<string>();
            q11.Add("Frank Sinatra");
            q11.Add("Freddie Mercury");
            q11.Add("Bobby Ljungren");
            q11.Add("Etta James");

            List<string> q12 = new List<string>();
            q12.Add("Tim Bergling");
            q12.Add("Marsmallow and Etta James");
            q12.Add("Skrillex and Tim Bergling");
            q12.Add("Ash Purnouri, Etta James, Leroy Kirkland, Pearl Woods and Tim Bergling");



            alternatives = new List<KeyValuePair<string, List<string>>>()
            {
                new KeyValuePair<string,List<string >>("Politics",q1),
                new KeyValuePair<string, List<string>>("Politics",q2),
                new KeyValuePair<string, List<string>>("Politics",q3),
                new KeyValuePair<string, List<string>>("Politics",q4),

                new KeyValuePair<string,List<string >>("Geography",q5),
                new KeyValuePair<string, List<string>>("Geography",q6),
                new KeyValuePair<string, List<string>>("Geography",q7),
                new KeyValuePair<string, List<string>>("Geography",q8),

                new KeyValuePair<string,List<string >>("Music",q9),
                new KeyValuePair<string, List<string>>("Music",q10),
                new KeyValuePair<string, List<string>>("Music",q11),
                new KeyValuePair<string, List<string>>("Music",q12),
            };


        }
    }
}