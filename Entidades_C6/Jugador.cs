using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C6
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            dni = 0;
            nombre = "";
            partidosJugados = 0;
            promedioGoles = 0;  
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            Jugador j = new Jugador();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni.ToString());
            sb.AppendLine("partidos jugador: " + this.partidosJugados.ToString());
            sb.AppendLine("total goles: " + this.totalGoles.ToString());
            sb.AppendLine("Promedio goles: " + this.GetPromedioGoles().ToString());

            return sb.ToString();

        }
    }
}
