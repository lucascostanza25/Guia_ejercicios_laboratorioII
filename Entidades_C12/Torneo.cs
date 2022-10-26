using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C12
{
    public class Torneo <T> where T : Equipo
    {
        private List<Equipo> listaEquipos;
        private string nombre;

        private Torneo()
        {
            listaEquipos = new List<Equipo>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> miTorneo, T equipo)
        {
            foreach(T item in miTorneo.listaEquipos)
            {
                if(item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> miTorneo, T equipo)
        {
            return !(miTorneo == equipo);
        }

        public static bool operator +(Torneo<T> miTorneo, T equipo)
        {
            if((miTorneo is not null && equipo is not null) && miTorneo != equipo)
            {
                miTorneo.listaEquipos.Add(equipo);
                return true;
            }

            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach(T equipo in listaEquipos)
            {
                sb.AppendLine(equipo.Ficha());
            } 
            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{e1.nombre}{random.Next(0, 10)} - {random.Next(0, 10)}{e2.nombre}");
            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random partidoRandom = new Random();
                T equipoUno;
                T equipoDos;

                do
                {
                    equipoUno = listaEquipos[partidoRandom.Next(0, listaEquipos.Count)];
                    equipoDos = listaEquipos[partidoRandom.Next(0, listaEquipos.Count)];
                } while (equipoUno == equipoDos);

                return CalcularPartido(equipoUno, equipoDos);
            }
        }
    }
}
