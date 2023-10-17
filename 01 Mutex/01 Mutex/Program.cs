using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Mutex
{
    internal class Program
    {
        static void Main(string[] args)
        {

                var mutex = new Mutex(false, "miMutexUnico");

                var proceso1 = new Thread(() =>
                {
                    Console.WriteLine("IniciandoProceso1");
                    mutex.WaitOne();

                    Console.WriteLine("Proceso 1 accediendo al recurso");
                    Thread.Sleep(3000);

                    mutex.ReleaseMutex();
                    Console.WriteLine("FinalizandoProceso1");
                });

                var proceso2 = new Thread(() =>
                {
                    Console.WriteLine("IniciandoProceso2");
                    mutex.WaitOne();

                    Console.WriteLine("Proceso 2 accediendo al recurso");
                    Thread.Sleep(3000);

                    mutex.ReleaseMutex();

                    Console.WriteLine("FinalizandoProceso1");
                });

                proceso1.Start();
                proceso2.Start();

                proceso1.Join();
                proceso2.Join();

                Console.WriteLine("Fin del programa");

                Console.ReadKey();
        }
    }
}
