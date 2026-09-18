using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //procedimiento sumar
        public static void ImprimirSumar(int a, int b) //Son los parametros
        {
            int suma = a + b;    
            Console.WriteLine(suma);
        }
        public static void MostrarPotenciaX(double num1,double pot)
        {
            double pote = Math.Pow( num1,  pot);
            Console.WriteLine($"La potencia de {num1} elevado a {pot} es: {pote}");
        }

        static void ModificarValor(int n)
        {
            n = n + 1;
            Console.WriteLine($"Dentro del metodo: {n}" );

        }

        static void Main(string[] args)
        {
            int x = 12, y= 23;
            ImprimirSumar(y, x);//y,x Los argumentos actuales 
            ImprimirSumar(1000, -1);//1000, -1 Argumentos Literales

            double num1 = 12, pot = 3;
            MostrarPotenciaX(num1, pot);

            int edad = 24;
            Console.WriteLine($"Antes del metodo: {edad}");

            ModificarValor(edad);
            Console.WriteLine($"Despues del metodo {edad}");

        }

    }
}
