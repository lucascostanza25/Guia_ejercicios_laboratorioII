using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_EjercicioClase01
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string miString = Sello.mensaje;
            Sello.Borrar();
            for(int i=0; i<miString.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            for (int i = 0; i < miString.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            return miString;
        }
    }
}
