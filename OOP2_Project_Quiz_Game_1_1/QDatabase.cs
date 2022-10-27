using System;
using System.Collections.Generic;

namespace OOP2_Project_Quiz_Game_1_1
{
    public class QDatabase
    {
          public List<KeyValuePair<string, string>> questions { get; set; }
         public List<KeyValuePair<string, string>> answers { get; set; }
         public List<KeyValuePair<string, List<string>>> alternatives { get; set; }

        public QDatabase()
        {
            
            questions = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Great Britain?"),
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of France?"),
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string, string>("Geography","Who is the prime minister of Sweden?"),
            };

               answers = new List<KeyValuePair<string, string>>()
            {
                 new KeyValuePair<string,string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Politics","Who is the president of Sweden?"),
                 new KeyValuePair<string,string>("Politics","Who is the chansler of Sweden?"),
                 new KeyValuePair<string,string>("Politics","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Sports","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
                 new KeyValuePair<string,string>("Geography","Who is the prime minister of Sweden?"),
            };


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

            alternatives = new List<KeyValuePair<string, List<string>>>()
            {
                new KeyValuePair<string,List<string >>("Politics",q1),
                new KeyValuePair<string, List<string>>("Politics",q2),
                new KeyValuePair<string, List<string>>("Politics",q3),
                new KeyValuePair<string, List<string>>("Politics",q4),
            };
    

        }







/*    public List<KeyValuePair<string, List<string>>> alternatives = new List<KeyValuePair<string, List<string>>>(

                ("Politics", ("Magdalena Andersson", "Ulf Kristersson", "Stefan Löfven", "Fredrik Reinfeldt")),
                ("Politics", ("Boris Johnson", "Liz Truss", "Rishi Sunak", "Tony Blair")),
               ("Politics", ("Emanuel Macron", "Jacques Chirac", "Nicolas Sarkozy", "Francois Hollande")),
               ("Politics", ("Olaf Shoiz", "Angela Merkel", "Gerhard Schröder", "Helmut Kohl"))); */
        
        public void printList <T>(List<T> list)
            {
                foreach (var a in list)
                {
                    Console.WriteLine(a);
                }
            }




        
    }
}

