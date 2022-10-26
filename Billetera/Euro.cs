using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Euro()
        {
            Euro.cotzRespectoDolar = 1/1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool estado = false;
            if (e.cantidad == d.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool estado = false;
            if (e.cantidad == p.GetCantidad())
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool estado = false;
            if (e1.cantidad == e2.cantidad)
            {
                estado = true;
            }

            return estado;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).GetCantidad());
        }
    }
}
