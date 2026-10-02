// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public class HelloWorld {
    public static void Main(string[] args) {
    string[] nombreestudiantes = new string [19];
    double[] notaestudiantes = new double[19];
        for (int i = 0; i < nombreestudiantes.Length; i++) 
        { 
           Console.WriteLine ($"Digite el nombre del estudiante numero: {i + 1} ");
            nombreestudiantes[i] = Console.ReadLine();  
            Console.WriteLine ($"Digite la nota del estudiante numero: {i + 1} ");
            notaestudiantes[i] = Convert.ToDouble(Console.ReadLine());  
                
        }
        
            double suma = 0;
            double nmdg = notaestudiantes[0];
            double nmedg = notaestudiantes[0];

         for (int i = 0; i < notaestudiantes.Length; i++)
            {
                suma += notaestudiantes[i]; 
                if (notaestudiantes[i] > nmdg);
             {
                 nmdg = notaestudiantes[i];
             }
                if (notaestudiantes[i] < nmedg);
             {
                 nmedg = notaestudiantes[i];
             }

            }
             double promedio = suma / notaestudiantes.Length; 

            Console.WriteLine("\n---Reporte ----"); 
            Console.WriteLine($"Estudiantes: {string.Join(",", nombreestudiantes)}");
            Console.WriteLine($"Promedio de notas: {promedio:F2}°C");
            Console.WriteLine($"Nota mas alta: {nmdg:F2}");
            Console.WriteLine($"Nota mas baja: {nmedg:F2}");
     



       
    }
}
