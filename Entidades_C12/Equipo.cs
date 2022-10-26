using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C12
{
    public abstract class Equipo
    {
        public string nombre { get; set; }
        DateTime fechaCreacion { get; set; }

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                return true;
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre} fundado el {fechaCreacion}");
            return sb.ToString();
        }
    }
}
