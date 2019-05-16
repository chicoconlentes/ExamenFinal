using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProblemaIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            char[] b = new char[nombre.Length];//Lee y convierte nombre a arreglo

            string apellido;
            Console.WriteLine("Escribe tu apellido");
            apellido = Console.ReadLine();
            char[] a = new char[apellido.Length];//Lee y convierte apellido a arreglo

            if (a.Length < 3)
                Console.WriteLine("apellido invalido");
            else if (b.Length < 3)
                Console.WriteLine("nombre invalido"); //Validador de datos

                Console.ReadKey();
        }
    }
}
