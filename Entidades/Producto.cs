using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto miProducto)
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine($"{miProducto.marca}");
            mySb.AppendLine($"{miProducto.precio}");
            mySb.AppendLine($"{miProducto.codigoDeBarra}");

            return mySb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            string retorno = p.codigoDeBarra.ToString();
            return retorno;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool estado = false;

            if(p.marca == marca)
            {
                estado = true; 
            }

            return estado;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }
    }
}
