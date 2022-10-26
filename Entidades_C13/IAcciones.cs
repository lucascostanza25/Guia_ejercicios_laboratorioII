using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_C13
{
    public interface IAcciones
    {
        ConsoleColor color { get; set; }
        float UnidadesDeEscritura { get; set; }
        EscrituraWrapper Escribir(string texto);
        bool Regargar(int unidades);
    }
}
