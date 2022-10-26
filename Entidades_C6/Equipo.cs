using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C6
{
    public class Equipo
    {
        private short cantiadadJugadores;
        private List<Jugador> listaJugadores;
        private string nombre;

        private Equipo()
        {
            listaJugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantiadadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.cantiadadJugadores > e.listaJugadores.Count)
            {
                foreach (Jugador jugador in e.listaJugadores)
                {
                    if (jugador == j) return false;
                }
                e.listaJugadores.Add(j);
                return true;
            }
            else return false;
        }

    }
}
