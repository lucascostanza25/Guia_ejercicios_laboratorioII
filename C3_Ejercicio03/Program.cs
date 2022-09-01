using System;
using Entidades;

namespace C3_Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 3 - Ejercicio 3";
            Estudiante miEstudianteUno = new Estudiante("Lucas", "Costanza", "0001");
            Estudiante miEstudianteDos = new Estudiante("Eliana", "Gonzalez", "0002");
            Estudiante miEstudianteTres = new Estudiante("Federico", "Molinero", "0003");

            miEstudianteUno.SetNotaPrimerParcial(7);
            miEstudianteUno.SetNotaSegundoParcial(7);

            miEstudianteDos.SetNotaPrimerParcial(9);
            miEstudianteDos.SetNotaSegundoParcial(7);

            miEstudianteTres.SetNotaPrimerParcial(2);
            miEstudianteTres.SetNotaSegundoParcial(3);

            Console.WriteLine(miEstudianteUno.Mostrar());
            Console.WriteLine(miEstudianteDos.Mostrar());
            Console.WriteLine(miEstudianteTres.Mostrar());

            Console.ReadLine(); 
        }
    }
}
