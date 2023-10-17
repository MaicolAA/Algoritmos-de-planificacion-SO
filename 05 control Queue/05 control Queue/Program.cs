using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_control_Queue
{
    internal class Program
    {
        public static void Main()
        {
            Queue<string> cola = new Queue<string>();

            cola.Enqueue("Tarea 1");
            cola.Enqueue("Tarea 2");
            cola.Enqueue("Tarea 3");

            while (cola.Count > 0)
            {
                string tarea = cola.Dequeue();
                Console.WriteLine($"Procesando: {tarea}");
            }
            Console.WriteLine("Todas las tareas han sido procesadas");

            Console.ReadKey();
        }
    }
}
