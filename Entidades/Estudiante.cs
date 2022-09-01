using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random numeroRandom = new Random();

        private Estudiante()
        {
            this.apellido = "";
            this.nombre = "";
            this.legajo = "";
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public bool SetNotaPrimerParcial(int notaRecibida)
        {
            bool estado = false;
            if (notaRecibida >= 1)
            {
                this.notaPrimerParcial = notaRecibida;
                estado = true;
            }

            return estado;
        }

        public bool SetNotaSegundoParcial(int notaRecibida)
        {
            bool estado = false;
            if (notaRecibida >= 1)
            {
                this.notaSegundoParcial = notaRecibida;
                estado = true;
            }

            return estado;
        }

        private int CalcularPromedio()
        {
            int resultado = (this.notaPrimerParcial + notaSegundoParcial) / 2;
            return resultado;
        }

        public int CalcularNotaFinal()
        {
            int resultado = 0;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                resultado = numeroRandom.Next(6, 10);
            }
            else resultado = -1;

            return resultado;
        }

        public string Mostrar()
        {
            int promedio = CalcularPromedio();
            int notaFinal = CalcularNotaFinal();
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine($"Nombre, apellido y legajo: {nombre} {apellido} | {legajo}");
            mySb.AppendLine($"Nota primer parcial, nota segundo parcial: {notaPrimerParcial} | {notaSegundoParcial}");
            mySb.AppendLine($"Promedio: {promedio}");
            if (notaFinal > -1) mySb.AppendLine($"Nota final: {notaFinal}");
            else mySb.AppendLine($"Nota final: Alumno desaprobado");

            return mySb.ToString();
        }
    }
}
