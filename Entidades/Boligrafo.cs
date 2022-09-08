using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const int cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private bool SetTinta(int tinta)
        {
            bool estado = false;
            int cantidadTinta = Boligrafo.cantidadTintaMaxima;
            if(cantidadTinta >= 0)
            {
                this.tinta = (short)tinta;
                estado = true;
            }

            return estado;
        }
    }
}
