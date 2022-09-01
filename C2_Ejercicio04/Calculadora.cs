using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio04
{
    internal class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, string operando)
        {
            float resultado = 0;

            switch(operando)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;

                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;

                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;

                case "/":
                    if(Validar(segundoOperando) == true)
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.Write("No se puede dividir por 0\n");
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(float segundoOperando)
        {
            if(segundoOperando == 0)
            {
                return false;
            }
            return true;
        }
    }
}
