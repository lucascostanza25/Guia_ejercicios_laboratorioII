using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C10
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base("No hay parametros posibles")
        {
        }

        public ParametrosVaciosException(string message) : base(message)
        {
        }

        public ParametrosVaciosException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
