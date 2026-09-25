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
            double[] codigos = new double[20]; 
          
            Console.WriteLine("-----Ingrese los codigos codigos-----");

            for (int i = 0; i < codigos.Length; i++)  
            {
                Console.WriteLine($"Ingrese el codigo nummero {i + 1}: "); 
                codigos[i] = Convert.ToDouble(Console.ReadLine()); 

            }

            Console.WriteLine($"Los Codigos actuales son: {string.Join(",", codigos)}");
            Console.WriteLine("Ingrese el codigo que desea actualizar: ");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceencontrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceencontrado = i;
                    break;
                }

            }
          
            if (indiceencontrado != -1) 
            {
                Console.WriteLine("Ingrese el nuevo codigo: ");
                codigos[indiceencontrado] = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"\nVector actualizado: {string.Join(",", codigos)}");
            }
            else
            {

                Console.WriteLine("\nError: el codigo ingresado no existe en la BDD");
            }
            Console.WriteLine($"el valor del indice {indiceencontrado}");





        }
    }
}
