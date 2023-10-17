using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_DeadLockstarvation
{
    internal class Program
    {

          private static object candado1 = new object();
          private static object candado2 = new object();

        public static void Main()
        {
            Thread hilo1 = new Thread(() =>
            {
                lock (candado1)
                {
                    Console.WriteLine("El  hilo 1 -> Bloqueo el recurso 1");
                    Thread.Sleep(100);
                    lock (candado2)
                    {
                        Console.WriteLine("El hilo 1 -> Bloqueo el recurso 2");
                    }
                }
            });

            Thread hilo2 = new Thread(() =>
            {
                lock (candado2)
                {
                    Console.WriteLine("El hilo 2 -> Bloqueo el recurso 2");
                    Thread.Sleep(100);
                    lock (candado1)
                    {
                        Console.WriteLine("El hilo 2 -> Bloqueo el recurso 1");
                    }
                }
            });

            hilo1.Start();
            hilo2.Start();

            hilo1.Join();
            hilo2.Join();

            Console.WriteLine("fin del programa");
            Console.ReadKey ();
        }
        
    }
}
    

