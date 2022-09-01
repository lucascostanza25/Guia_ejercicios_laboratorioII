/* Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
 * bool Validar(int valor, int min, int max)
 * Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

   Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio. */

using System;

namespace C2_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 2 - Ejercicio 1";
            string numeroIngresado;
            int numeroParseado, numeroMaximo = 0, numeroMinimo = 0, acumulador = 0;
            float promedio = 0;
            bool flag = false;

            for(int i=0; i<10; i++)
            {
                Console.Write($"Ingresa 10 numeros ({i}/10): ");
                numeroIngresado = Console.ReadLine();   
                if(int.TryParse(numeroIngresado, out numeroParseado) == true)
                {
                    if (Validador.Validar(numeroParseado, -100, 100) == true)
                    {
                        Console.Write("El numero ingresado SI se encuentra dentro del rango\n");
                        if (!flag)
                        {
                            numeroMaximo = numeroParseado;
                            numeroMinimo = numeroParseado;
                            flag = true;
                        }
                        if (numeroMaximo < numeroParseado)
                        {
                            numeroMaximo = numeroParseado;
                        }
                        if (numeroMinimo > numeroParseado)
                        {
                            numeroMinimo = numeroParseado;
                        }
                        
                        acumulador += numeroParseado;
                    }
                    else
                    {
                        Console.Write("El numero ingresado NO se encuentra dentro del rango\n");
                    }
                }
                else
                {
                    Console.Write("Por favor ingrese un numero\n");
                }
            }

            promedio = (float)acumulador / 10;

            Console.Write($" -------------------------- \n" +
                $"El numero maximo es: {numeroMaximo}\n" +
                $"El numero minimo es: {numeroMinimo}\n" +
                $"El promedio es: {promedio}\n");

            Console.ReadLine(); 
        }
    }
}
