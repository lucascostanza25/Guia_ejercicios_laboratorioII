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

        public Pesos(double cantidad, double cotizacion) : this (cantidad)
        {
            Pesos.cotzRespectoDolar = cotizacion;
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

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool estado = false;
            if (p.cantidad == d.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool estado = false;
            if (p.cantidad == e.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool estado = false;
            if (p1.cantidad == p2.cantidad)
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).GetCantidad());
        }
    }
}
