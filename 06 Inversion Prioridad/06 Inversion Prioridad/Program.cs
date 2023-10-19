using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Inversion_Prioridad
{
    internal class Program
    {
        public static void Main()
        {
            // Creamos tres hilos con  prioridades distintas

            Thread hiloPrioridadBaja = new Thread(TareaPrioridadBaja);
            hiloPrioridadBaja.Priority = ThreadPriority.BelowNormal;

            Thread hiloPrioridadAlta = new Thread(TareaPrioridadAlta);
            hiloPrioridadAlta.Priority = ThreadPriority.AboveNormal;

            Thread hiloPrioridadMedia = new Thread(TareaPrioridadMedia);
            hiloPrioridadMedia.Priority = ThreadPriority.Normal;

            hiloPrioridadBaja.Start();
            hiloPrioridadAlta.Start();
            hiloPrioridadMedia.Start();


            Console.ReadKey();
        }

        static void TareaPrioridadBaja()
        {
            Console.WriteLine("Hilo de baja prioridad se esta ejecutando");
            Thread.Sleep(2000);
            Console.WriteLine("Hilo de baja prioridad ha terminado");
        }

        static void TareaPrioridadMedia()
        {
            Console.WriteLine("Hilo de prioridad media se esta ejecutando");
            Thread.Sleep(1500);
            Console.WriteLine("Hilo de prioridad media ha terminado");
        }

        static void TareaPrioridadAlta()
        {
            Console.WriteLine("Hilo de alta prioridad se esta ejecutando");
            Thread.Sleep(1000);
            Console.WriteLine("Hilo de alta prioridad ha terminado");
        }

        
    }
}
