/* Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/

using System;

namespace C1_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 1 - Ejercicio 02";
            double numeroIngresado = 0;
            double cuadrado = 0, cubo = 0;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse((Console.ReadLine()));

            while (numeroIngresado == 0)
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numeroIngresado = int.Parse((Console.ReadLine()));
            }

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.Write($"El cuadrado del numero {numeroIngresado} es: {cuadrado}\n" +
                          $"El cubo del numero {numeroIngresado} es: {cubo}");
            Console.ReadLine();
        }
    }
}
