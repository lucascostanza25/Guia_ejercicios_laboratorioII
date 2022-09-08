using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            long resultado = 0;
            this.cantidadSumas++;

            resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(a);
            sb.AppendLine("" + b);

            return sb.ToString();
        }

        public static explicit operator int(Sumador miSuma)
        {
            return miSuma.cantidadSumas;
        }

        public static long operator +(Sumador operandoUno, Sumador operandoDos)
        {
            return operandoUno + operandoDos;
        }

        public static bool operator | (Sumador operandoUno, Sumador operandoDos)
        {
            bool estado = false;

            if(operandoUno.cantidadSumas == operandoDos.cantidadSumas)
            {
                estado = true;
            }

            return estado;
        }
    }
}
