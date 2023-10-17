using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task_Scheduling
{
    internal class Program
    {
        public static void Main()
        {
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Tarea 1 en ejecución...");
            });

            Task task2 = Task.Run(() =>
            {
                Console.WriteLine("Tarea 2 en ejecución...");
            });

            Task task3 = Task.Run(() =>
            {
                Console.WriteLine("Tarea 3 en ejecución...");
            });

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("Todas las tareas han terminado");


            Console.ReadKey();
        }
    }
}
