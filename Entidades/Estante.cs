using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");

            for(int i = 0; i < e.productos.Length; i++) //e.productos.Lenght --> llamo al arrar de productos desde el objeto Estante
            {
                if(!object.ReferenceEquals(e.productos[i], null))
                {
                    mySb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    mySb.AppendLine("----------------------");
                }
            }

            return mySb.ToString();
        }


        //sobre carga 
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return true;

                }
            }

            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);

        }
        public static bool operator +(Estante e, Producto p)
        {

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;

                    }
                }
            }

            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;

        }
    }
}
