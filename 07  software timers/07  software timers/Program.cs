using System;
using System.Timers;

namespace _07__software_timers
{
    internal class Program
    {
        public static void Main()
        {
            Timer timer = new Timer(2000); // 2s

            timer.Elapsed += (sender, e) => {
                Console.WriteLine("Temporizador activado");
            };

            timer.AutoReset = false; // El temporizador no se reiniciara en automatico
            timer.Start();

            Console.WriteLine("Esperando la activación del temporizador...");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
