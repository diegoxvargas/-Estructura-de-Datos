using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "Ventas.txt";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio,Cantidad");
            sw.WriteLine("1,Laptop,1200,5");
            sw.WriteLine("2,Mouse,25,3");
            sw.WriteLine("3,Monitor,300,6");
            sw.WriteLine("4,Parlantes,200,2");
            sw.WriteLine("5,Audifonos,5,5");
            sw.WriteLine("6,Guantes,25,10");
            sw.WriteLine("7,Cable HDMI,20,30");
        }
        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double Cantidad = double.Parse(campos[3]);
            string Producto = string.Concat(campos[1]);
            double precio = double.Parse(campos[2]);
            double Total = 0;
            double masvendido = 0;
            Console.WriteLine($"{campos[1]} - {Cantidad}");
            Total += precio[i];

        }
    }
}
