using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades_C7
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            if(cli != null)
            {
                Thread.Sleep(2000);
                return true;
            }

            return false;
        }
    }
}
