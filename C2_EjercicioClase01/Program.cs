using System;

namespace C2_EjercicioClase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";

            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            Sello.mensaje = "hola mundo C#";

            Console.WriteLine(Sello.Imprimir());

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

            Console.ReadLine();
        }
    }
}
