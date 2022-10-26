using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_EjercicioOffShore
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;
        

        public CuentaOffShore(Cliente dueño, int numeroCuenta, double saldoInicial)
        {
            _dueño = dueño;
            _numeroCuenta = numeroCuenta;
            _saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, Cliente.eTipoCliente tipo, int numero, double saldoInicial)
        {
            
        }

        public static explicit operator int(CuentaOffShore cuenta)
        {
            return cuenta._numeroCuenta;
        }

        public static bool operator ==(CuentaOffShore c1, CuentaOffShore c2)
        {
            
            if(c1._numeroCuenta == c2._numeroCuenta)
        }
    }
}
