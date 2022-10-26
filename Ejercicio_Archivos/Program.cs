using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Ejercicio_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            FileStream fileStream = File.Open("C:\\Users\\Lucas\\Downloads\\Lista Grandiet_Palermo.xlsx", FileMode.Open, FileAccess.Read);
            sb.AppendLine(fileStream.ReadByte().ToString());
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
