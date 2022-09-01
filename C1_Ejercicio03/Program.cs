/* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola. */

using System;

namespace C1_Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 1 - Ejercicio 03";
            string opcion;
            int numeroParseado = 0;
            bool estado;
            int divisible = 0;
            int numero = 2;

            do
            {
                Console.Write("Ingrese una opcion o escriba 'salir' para cerrar el programa: ");
                opcion = Console.ReadLine();
                estado = int.TryParse(opcion, out numeroParseado);

                if (estado == true)
                {
                    while (numero <= numeroParseado)
                    {
                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                divisible++;
                            }
                            if (divisible > 2)
                            {
                                break;
                            }
                        }

                        if (divisible == 2)
                        {
                            Console.WriteLine($"{numero}");
                        }
                        divisible = 0;
                        numero++;
                    }
                }
            } while (opcion != "salir");
            Console.ReadLine();
        }
    }
}
