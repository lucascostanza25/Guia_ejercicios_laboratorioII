using System;
using C2_Ejercicio01;

namespace C2_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 2 - Ejercicio 02";
            string respuesta;
            int numeroIngresado;

            do
            {
                Console.Write("¿Desea continuar?: ");
                respuesta = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuesta) == true);
            Console.ReadLine();
        }
    }
}
