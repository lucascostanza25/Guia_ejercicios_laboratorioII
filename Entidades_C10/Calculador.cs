using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C10
{
    public static class Calculador
    {
        public static int Calcular(int numeroUno, int numeroDos)
        {
            if(numeroDos == 0)
            {
                throw new DivideByZeroException();
            }
            return numeroUno / numeroDos;
        }
    }
}
