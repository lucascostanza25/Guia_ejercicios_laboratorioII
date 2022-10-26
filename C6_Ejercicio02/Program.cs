using System;
using System.Collections.Generic;
using System.Linq;

namespace C6_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 6 - Ejercicio 2";
            List<int> myList = new List<int>();
            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                myList.Add(random.Next(-100, 100));
                myQueue.Enqueue(random.Next(-100, 100));
                myStack.Push(random.Next(-100, 100));
            }
            Console.WriteLine("Lista original:");
            foreach (int i in myList)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("\nQueue original:");
            foreach (int i in myQueue)
            {
                if (i < 0)
                    Console.Write(" " + i);
            }
            Console.WriteLine("\nStack original:");
            foreach (int i in myStack)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("Lista positivos ordenada decreciente:");
            myList.Sort(Program.OrdenarDecreciente);
            foreach (int i in myList)
            {
                if (i > 0) Console.Write(" " + i);
            }
            Console.WriteLine("\nLista negatica ordenada creciente:");
            myList.Sort(Program.OrdenarCreciente);
            foreach (int i in myList)
            {
                if (i < 0) Console.Write(" " + i);
            }
            //Queue
            Console.WriteLine("\nQueue positiva ordenada decreciente:");
            var a = myQueue.ToList();
            a.Sort(Program.OrdenarDecreciente);
            foreach (int i in a)
            {
                if (i > 0) Console.Write(" " + i);
            }
            Console.WriteLine("\nQueue negativa ordenada creciente:");
            a.Sort(Program.OrdenarCreciente);
            foreach (int i in a)
            {
                if (i < 0) Console.Write(" " + i);
            }
            //Stack
            Console.WriteLine("\nStack positiva ordenada decreciente:");
            var b = myStack.ToList();
            
            Console.ReadLine();
        }

        public static int OrdenarDecreciente(int a, int b)
        {
            return b - a;
        }

        public static int OrdenarCreciente(int a, int b)
        {
            return a - b;
        }
    }
}
