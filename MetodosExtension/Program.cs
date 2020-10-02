using CustomExtensions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //dll extendida
            DateTime hoy = DateTime.Now;
            Console.WriteLine($"Fecha actual { hoy.FormatoFecha() }");


            //clase  extendida
            Persona persona = new Persona()
            {
                Nombre = "Juan",
                Edad = 12
            };

            try
            {
                persona.Validar();
                Console.WriteLine("Persona válida");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message } ");
            }

            Console.ReadKey();
        }
    }
}
