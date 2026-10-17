
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";
        string[] lineas = File.ReadAllLines(ruta);

        Dictionary<string, int> ventas = new Dictionary<string, int>();
        int total = 0;

       for (int i = 0; i < lineas.Length; i++)
{
    string[] campos = lineas[i].Split(':');

    string producto = campos[0];
    int cantidad = int.Parse(campos[1]);

            if (ventas.ContainsKey(producto))
                ventas[producto] += cantidad;
            else
                ventas[producto] = cantidad;

            total += cantidad;
        }

        string masVendido = "";
        int mayorCantidad = 0;

        foreach (var venta in ventas)
        {
            if (venta.Value > mayorCantidad)
            {
                mayorCantidad = venta.Value;
                masVendido = venta.Key;
            }
        }

        Console.WriteLine("Total de unidades vendidas: " + total);
        Console.WriteLine("Producto más vendido: " + masVendido);
        Console.WriteLine("Cantidad vendida: " + mayorCantidad);
    }
}
