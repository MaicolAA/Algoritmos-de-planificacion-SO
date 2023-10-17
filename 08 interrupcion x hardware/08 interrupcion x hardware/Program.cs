using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_interrupcion_x_hardware
{
    internal class Program
    {
        static void Main()
        {
            SerialPort serialPort = new SerialPort("COM3");

            try
            {
                serialPort.Open();
                Console.WriteLine("Puerto COM abierto. Puedes enviar y recibir datos.");

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tienes permisos para acceder al puerto COM.");
            }
            catch (IOException)
            {
                Console.WriteLine("El puerto COM no pudo ser abierto.Revisa que el dispositivo este conectado y no este siendo utilizado por otra appp");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
            finally
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Console.WriteLine("Puerto COM cerrado.");
                }
            }


            Console.ReadKey();
        }
    }
}
