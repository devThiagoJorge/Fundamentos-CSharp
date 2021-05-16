using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Informe o tempo a ser percorrido...\nSegundos => 50s = 50 segundos\nMinutos => 1m = 1 minuto\n0 => Sair");
            string data = Console.ReadLine().ToLower();

            string type = data.Substring(data.Length - 1, 1);
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (time == 0 && type != "m" && type != "s")
                System.Environment.Exit(0);

            if (type == "m")
                multiplier = 60;

            Start(time * multiplier);

        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finish stopwatch...");
        }
    }
}
