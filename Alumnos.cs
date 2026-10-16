using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "Alumnos.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("Diego,24,4.1");
            sw.WriteLine("Jose,17,3.3");
            sw.WriteLine("Nicolle,19,5.0");
        }
        Console.WriteLine("Registro realizado con exito");
    }
}
