using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static bool operator == (Dolar d,  Pesos p)
        {
            bool estado = false;
            if (d.cantidad == p.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool estado = false;
            if (d.cantidad == e.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool estado = false;
            if (d1.cantidad == d2.cantidad)
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }
    }
}
