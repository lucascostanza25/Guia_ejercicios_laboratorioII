using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C7
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> queueCliente;
        private string nombre;
        
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.queueCliente = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return queueCliente.Dequeue(); }
            set { _ = this + value; }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente miCliente in n.queueCliente)
            {
                if(c == miCliente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            foreach (Cliente miCliente in n.queueCliente)
            {
                if (c != miCliente)
                {
                    n.queueCliente.Enqueue(c);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if(n.queueCliente.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            get { return this.queueCliente.Count; }
        }
    }
}
