/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/

using System;

namespace C2_Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 2 - Ejercicio 4";
            string opcion, operando;
            float primerOperando, segundoOperando, resultado;

            do
            {
                Console.Write("CALCULADORA\n" +
                    "1.Ingresar operandos\n" +
                    "2.Ver resultados\n");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese que tipo de operando desea utilizar: ");
                        operando = Console.ReadLine();
                        Console.Write("Ingrese el primer operando: ");
                        primerOperando = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo operando: ");
                        segundoOperando = float.Parse(Console.ReadLine());
                        resultado = Calculadora.Calcular(primerOperando, segundoOperando, operando);
                        
                        break;

                    case "2":
                        Console.WriteLine(resultado);
                        break;
                }
            } while (opcion != "salir");
        }
    }
}
