using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_EjercicioOffShore
{
    public class Cliente
    {
        public enum eTipoCliente
        {
            PoliticoCorrupto,
            EmpresarioCorrupto,
            JugadorDeFutbol,
            Financista,
            SinTipo
        }

        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            StringBuilder mySb = new StringBuilder();
            Random miRandom = new Random();
            string numero = miRandom.Next(1000, 9999).ToString();
            this._aliasParaIncognito = mySb.AppendLine($"{numero}{this._tipoDeCliente}").ToString();
        }

        public string GetAlias()
        { 
            if(_aliasParaIncognito == "Sin alias") CrearAlias();
            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder mySb = new StringBuilder();
            mySb.AppendLine($"Nombre: {this._nombre}");
            mySb.AppendLine($"Alias: {this._aliasParaIncognito}");
            mySb.AppendLine($"Tipo de cliente: {this._tipoDeCliente}");

            return mySb.ToString();
        }
    }
}
