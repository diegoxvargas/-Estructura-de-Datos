using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5]
            { 7, 6, 5, 2, 8 };
            Console.WriteLine($"Elemento en [0]: {num[0]}");

            string[] estudiantes =
           { "Pedro", "juan", "Esteban", "Alvaro", "Danilo", "Janier", "Samuel"};

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"inddice [{i}]: {estudiantes[i]}");

            }
            
            double[] ventas = { 200.000, 302.300, 400.000, 300.233, 700.410, 700.432, 100.233, 99.423, 823.231, 902.211 };
            double total = 0;
            double mav = ventas[0];
            double mev = ventas[0];
            int Diamayorventa = 0;
            int Diamenorventa = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i]; // += significa que sumas cada vez que pasa por ahi

                if (ventas[i] > mav)
                {
                    mav = ventas[i];
                    Diamayorventa = i;
                }
                if (ventas[i] < mev)
                {
                    mev = ventas[i];
                    Diamenorventa = i;
                }

            }
            double promedio = total / ventas.Length; // ventas.length = total de ventas
            int diaSobrepromedi = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > promedio) 
                {
                    diaSobrepromedi++; // si resulta mayor, sumas uno con este comando. Asi cuentas los dias que sobrepasaron el promedio


                }

            }

            Console.WriteLine("-------------------REPORTE------------------");
            Console.WriteLine();
            Console.WriteLine($"Total vendido es de: {total:F3}");
            Console.WriteLine($"Promedio diario: {promedio:F3}");
            Console.WriteLine();
            Console.WriteLine($"Dia de mayores ventas: {Diamayorventa + 1}");
            Console.WriteLine($"Ganado el dia de mayores venta: {mav:F3}");
            Console.WriteLine();
            Console.WriteLine($"Dia de menores ventas: {Diamenorventa + 1}");
            Console.WriteLine($"Ganado el dia de menores venta: {mev:F3}");
            Console.WriteLine($"Cantidad de dias que pasaron el promedio de ventas: {diaSobrepromedi}");
            Console.WriteLine();
            Console.WriteLine("Ganancias de cada dia");
            for (int i = 0;i < ventas.Length;i++)
            {
                Console.WriteLine($"Dia {i + 1}: {ventas[i]:F3}"); //

            }

        }
    }
}
