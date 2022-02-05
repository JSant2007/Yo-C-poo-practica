using System;
using Yo.Persona;

namespace Yo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear Persona");
            Console.WriteLine("Inserta Nombre");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Inserta Edad");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            var Yo = new Persona.Persona(nombre1, edad2);

            Console.WriteLine(Yo);
        }
    }
}