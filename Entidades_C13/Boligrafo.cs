using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C13
{
    public class Boligrafo
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color { get; set; }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char c in texto)
            {
                if(c != ' ')
                {
                    this.tinta = this.tinta - (float)0.3;
                }
            }

            return new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }
            return false;
        }
    }
}