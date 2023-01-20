using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ball = new string[10];

            ball[0] = "Ja";
            ball[1] = "Tyst Kevin";
            ball[2] = "Nej";
            ball[3] = "absolut";
            ball[4] = "Defenitivt inte";
            ball[5] = "Om du tror kan du klara allt";
            ball[6] = "du klara inget";
            ball[7] = "Kromosonskada";
            ball[8] = "Nerd";
            ball[9] = "looser";

            bool spel = true;

            Random random = new Random();

            while (spel)
            {
                Console.WriteLine("Välkommen till Magic 8-ball");
                Console.Write("ställ din fråga: ");
                string fråga = Console.ReadLine();

                if(fråga == "a")
                {
                    spel = false;   
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine(ball[random.Next(0, 10)]);
                    Console.WriteLine();
                }
            }
        }
    }
}

