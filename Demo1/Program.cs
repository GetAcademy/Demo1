using System;
using Formatters;

namespace Demo1
{
    class Program
    {
        static string s;

        static void Main(string[] args)
        {
            var sum = 0;
            var n = 0;

            while (true)
            {
                var answerStr = Ask("Skriv et tall: ");
                var isSuccess = int.TryParse(answerStr, out int answer);
                if (isSuccess)
                {
                    sum += Convert.ToInt32(answer);
                    n++;
                }
                double avg = (double)sum / n;
                Console.WriteLine($"Summen er {sum}, gjennomsnitt er {avg}, antall tall er {n}.");
            }
        }

        private static string? Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        static void Variabler(string[] args)
        {
            // 1: deklarere
            int a;
            double b;
            string c;
            bool d;

            // 2: tilordne
            a = 3;
            b = 4.4;
            c = "Terje";
            //a = 3.3;
            //b = "Terje";
            //c = 3;

            // 1 og 2 på en gang
            char e;

            // 3: lese
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            Console.WriteLine(s);


        }
    }
}
