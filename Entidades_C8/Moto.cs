using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C8
{
    public class Moto : VehiculoTerrestre
    { 
        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private Colores color;
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.color = color;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadRuedas = cantidadRuedas;
            this.cilindrada = cilindrada;
        }
    }
}
