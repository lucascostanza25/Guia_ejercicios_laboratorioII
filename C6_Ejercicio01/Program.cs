using System;

namespace C6_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 6 - Ejercicio 1";
            int[] arrayNumeros = new int[20];
            Random random = new Random();
            Console.WriteLine("\nArray original");
            for (int i = 0; i < 20; i++)
            {
                arrayNumeros[i] = random.Next(-100, 100);
                Console.Write(arrayNumeros[i]); 
            }
            Console.WriteLine("\nNumeros positivos");
            for(int i = 0; i<20; i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.Write(arrayNumeros[i]);
                }
               
            }
            Console.WriteLine("\nNumeros negativos");
            for (int i = 0; i < 20; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.Write(arrayNumeros[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
