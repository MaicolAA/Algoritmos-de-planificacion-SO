using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_semaforo
{
    internal class Program
    {
        
        private static Semaphore semaforo = new Semaphore(2, 2); //cant hilos simultaneo

        public static void Main()
        {
            for (int i=0; i<5; i++)
            {
                Thread thread = new Thread(DoWork);
                thread.Start(i);
            }

            Console.ReadKey();
        }

        private static void DoWork(object id)
        {
            Console.WriteLine($"El hilo {id} esperando para acceder al recurso");
            semaforo.WaitOne();

            Console.WriteLine($"El hilo {id} accedio al recurso");
            Thread.Sleep(1000);

            semaforo.Release(); 
            Console.WriteLine($"El hilo {id} libero el recurso");


        }
    }
}
