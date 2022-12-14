using System;
using System.Text;

namespace Entidades_C5
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.nombre = nombre;
            this.genero = genero;
            this.direccion = direccion;
            this.pais = pais;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder mySb = new StringBuilder();

            if (Validar())
            {
                mySb.AppendLine($"Nombre: {this.nombre}");
                mySb.AppendLine($"Direccion: {this.direccion}");
                mySb.AppendLine($"Edad: {this.edad}");
                mySb.AppendLine($"Genero: {this.genero}");
                mySb.AppendLine($"Cursos: ");
                foreach (string miElemento in this.cursos)
                {
                    if (miElemento != null)
                    {
                        mySb.AppendLine("- " + miElemento);
                    }
                }
            }
            else
            {
                mySb.Append("No ingresó ningún dato!");
            }

            return mySb.ToString();
        }

        private bool Validar()
        {
            bool estado = false;
            if(this.cursos != null && this.nombre != null && this.direccion != null && this.genero != null && this.pais != null && this.edad >= 1)
            {
                estado = true;
            }

            return estado;
        }
    }
}
