using System;

namespace C3_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 3 - Ejercicio 2";
            Persona miPersonaUno = new Persona("Lucas", 1999, 12359);
            Persona miPersonaDos = new Persona("Eliana", 2000, 32598);
            Persona miPersonaTres = new Persona("Tito", 2020, 32957);

            Console.WriteLine(miPersonaUno.Mostrar());
            if (miPersonaUno.EsMayorDeEdad() == true) Console.WriteLine($"La persona {miPersonaUno.GetNombre()} es mayor de edad");
            Console.WriteLine(miPersonaDos.Mostrar());
            if (miPersonaDos.EsMayorDeEdad() == true) Console.WriteLine($"La persona {miPersonaDos.GetNombre()} es mayor de edad");
            Console.WriteLine(miPersonaTres.Mostrar());
            if (miPersonaTres.EsMayorDeEdad() == true) Console.WriteLine($"La persona {miPersonaTres.GetNombre()} es mayor de edad");
            else Console.WriteLine($"La persona {miPersonaTres.GetNombre()} es menor de edad");

            Console.ReadLine();
        }
    }
}
