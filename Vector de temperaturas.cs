using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; // Declarando e inicializando
            // Lectura y escritura de nuestros datos
            Console.WriteLine("-----Ingreso de temperaturas-----");

            for (int i = 0; i < temperaturas.Length; i++)  // Usamos .length para que el ciclo funcione en base al numero de elementos
            {
                Console.WriteLine($"Ingrese la temperatura del dia {i + 1}: "); // i + 1 Porque empieza desde 0
                temperaturas[i] = Convert.ToDouble(Console.ReadLine()); // toma los datos que ponga el usuario y los guarda en el vector
            
            }
            double suma = 0;
            double maxt = temperaturas[0];
            double mint = temperaturas[0];

            foreach (double tem in temperaturas)
            {
                suma += tem; // Es lo mismo que suma = suma + tem
                if (tem > maxt) maxt = tem;
                if (tem < mint) mint = tem;

            }
            double promedio = suma / temperaturas.Length; // La sumatoria de las temperaturas entre el tamaño del vector

            // Salida de informacion

            Console.WriteLine("\n---Reporte ----"); // \n es un salto de linea
            Console.WriteLine($"Temperaturas registrada: {string.Join(",", temperaturas)}");// string.join es para mostrar todo el vector separados por ,
            Console.WriteLine($"Temperatura Promedio: {promedio:F2}°C");//F2 es para mostrar 2 decimales, F3 es para ver 3 y asi
            Console.WriteLine($"Temperatura maxima es {maxt:F2}°C");
            Console.WriteLine($"Temperatura minima es {mint:F2}°C");

        }
    }
}
