using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Ejercicio01
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        /*public Cuenta()
        {
            this.titular = "";
            this.cantidad = 0;
        }*/

        public Cuenta(string nombreTitular, int cantidadTitular)
        {
            this.titular = nombreTitular;
            this.cantidad = cantidadTitular;
        }

        public string GetterTitular()
        {
            return this.titular;
        }

        public int GetterCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cantidad en la cuenta: ${this.cantidad}");
            return sb.ToString();
        }

        public bool Ingresar(int cantidadIngresar)
        {
            bool retorno = false;
            if(cantidadIngresar >= 0)
            {
                int nuevaCantidad = cantidad + cantidadIngresar;
                this.cantidad = nuevaCantidad;
                retorno = true;
            }
            return retorno;
        }

        public bool Retirar(int cantidadRetirar)
        {
            bool retorno = false;
            if (cantidadRetirar >= 0)
            {
                int cantidadCuenta = GetterCantidad();
                int nuevaCantidad = cantidadCuenta - cantidadRetirar;
                this.cantidad = nuevaCantidad;
                retorno = true;
            }
            return retorno;
        }
    }
}
