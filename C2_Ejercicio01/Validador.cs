using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio01
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarRespuesta(string letra)
        {
            if(letra == "S" || letra == "s")
            {
                return true;
            }
            return false;
        }
    }
}
