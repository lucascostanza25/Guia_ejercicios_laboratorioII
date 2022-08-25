/* Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

using System;

namespace C1_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 1 - ejercicio 01";
            int numeroIngresado = 0;
            int numeroMaximo = 0, numeroMinimo = 0, acumulador = 0;
            float promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese un numero ({i}/5): ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }

                if (numeroMaximo < numeroIngresado)
                {
                    numeroMaximo = numeroIngresado;
                }

                if (numeroMinimo > numeroIngresado)
                {
                    numeroMinimo = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = (float)acumulador / 5;

            Console.Write($"El numero maximo es: {numeroMaximo}\n" +
                          $"El numero minimo es {numeroMinimo}\n" +
                          $"El promedio es {promedio}");
            Console.ReadLine();
        }
    }
}
