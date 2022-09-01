using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Ejercicio02
{
    public class Persona
    {
        private string nombre;
        private int fechaDeNacimiento;
        private int dni;

        public Persona()
        {
            this.nombre = "";
            this.fechaDeNacimiento = 0;
            this.dni = 0;
        }

        public Persona(string nombrePersona, int fechaPersona, int dniPersona)
        {
            this.nombre = nombrePersona;
            this.fechaDeNacimiento = fechaPersona;
            this.dni = dniPersona;
        }
        #region Setters y Getters
        public void SetNombre(string nombrePersona)
        {
            this.nombre = nombrePersona;
        }

        public void SetFecha(int fecha)
        {
            this.fechaDeNacimiento = fecha;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetFecha()
        {
            return this.fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }
        #endregion
        private int CalcularEdad()
        {
            int edad = GetFecha();

            int resultado = 2022 - edad;

            return resultado;
        }

        public string Mostrar()
        {
            int edad = CalcularEdad();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}\nEdad: {edad}\nDNI: {this.dni}");

            return sb.ToString();
        }

        public bool EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            if(edad >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
