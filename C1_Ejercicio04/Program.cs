/* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

   El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

   Escribir una aplicación que encuentre los 4 primeros números perfectos.
 * */

using System;

namespace C1_Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 1 - Ejercicio 4";
            int numeroPerfecto = 6;
            int acumulador = 0;


            for (int i = 1; i < numeroPerfecto; i++)
            {
                if (numeroPerfecto % i == 0)
                {
                    acumulador += i;
                }
                numeroPerfecto = 28;
                if (numeroPerfecto % i == 0)
                {
                    acumulador += i;
                }
            }

            if (acumulador == numeroPerfecto) Console.WriteLine($"El numero {numeroPerfecto}, es perfecto\n");
            else Console.WriteLine($"El numero {8129}, no es perfecto");
            //Console.WriteLine($"el numero {numeroParseado}, es perfecto\n");
            
            Console.ReadLine();
        }
    }
}
