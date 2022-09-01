using System;

namespace C3_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 3 - Ejercicio 1";
            Cuenta miCuenta = new Cuenta("Lucas", 1000);
            int menu;

            do
            {
                Console.Write("1.Mostrar datos cuenta\n" +
                    "2.Ingresar dinero\n" +
                    "3.Retirar dinero\n" +
                    "\nSeleccione una opcion: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine(miCuenta.Mostrar());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        if (miCuenta.Ingresar(200) == true)
                        {
                            Console.WriteLine("Operacion realizada con exito");
                            Console.WriteLine("Cantidad en la cuenta actualmente: " + miCuenta.GetterCantidad());
                        }
                        else Console.WriteLine("No se pudo realizar la operacion");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        if (miCuenta.Retirar(1400) == true)
                        {
                            Console.WriteLine("Opreacion realizada con exito");
                            Console.WriteLine("Cantidad en la cuenta actualmente: " + miCuenta.GetterCantidad());
                        } 
                        else Console.WriteLine("No se pudo realizar la operacion");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (menu != 0);

            Console.ReadLine();
        }
    }
}
