using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Pesos()
        {
            Pesos.cotzRespectoDolar = 1/1.17;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Dolar.GetCotizacion());
        }
    }
}
