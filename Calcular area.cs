using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double CarcularAreacirculo(double radio)
        {
            const double PI = 3.141592;
            // ahora voy a realizar el calculo de la formula
            double area = PI * Math.Pow(radio, 2);
            //Decimos al final con return que devuelva el restultado de area
            return area;

        }
        static void Main(string[] args)
        {
            // aqui forzamos a que el resultado sea double, osea, del mismo tipo que el resto del proceso
            Console.Write("ingrese el radio del circulo: ");
            double r = Convert.ToDouble(Console.ReadLine());
           //le asignamos valor a la variable de radio
            double result = CarcularAreacirculo(r);
            //mostramos el resultado
            Console.WriteLine($"el area es: {result}");
        }
    }
}
