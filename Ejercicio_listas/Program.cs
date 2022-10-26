using System;
using System.Collections.Generic;

namespace Ejercicio_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(4);

            if(lista.Contains(4))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("Not true");
            }

            Console.ReadLine();
        }
    }
}
