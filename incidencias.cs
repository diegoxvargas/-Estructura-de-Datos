using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
// Registro de incidencias de soporte tecnico utilizado archivos (.txt).
// 1. Guardar en una lista de incidencias atendidas en un archivo de texto (incidencias.txt).
// 2. Leer el archivo .
// 3. Generar un reporte que ciaemta ciamas incidencias hay por prioridad (Alta, Media, Baja).
// 4. La estructura del archivo es: 10, NOMRE, DESCRIPCION, PRIORIDAD.
namespace ConsoleApp3
{
    internal class Program
    {
        //C:\Users\Sala-1\Desktop
        //Creando ruta para guardar mis incidencias
        static string pathArchivo = "incidencias.txt";
        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter SW = new StreamWriter(pathArchivo, false)) // usamos esto para escribir en el archivo y "false" es para reescribir el archivo
                {
                    foreach (string[] incidencia in incidencias) //para cada incidencia en el archivo incidencias escribir la incidencia
                    { 
                        SW.WriteLine(incidencia);
                    }
                
                }
            }
            catch (IOException ex )//IO porque usamos esa funcion antes en system
            { 
                
                Console.WriteLine($"Error al escribir el arcbivo:{ex.Message} ");//si falla manda este error

            }

        }
         
        static List<string[]> LeerIncidencias() //funcion para leer el archivo como una lista de texto
        { 
        
            List<string[]> incidencias = new List<string[]>();//creamos la lista como para guardar datos de texto
            if (!File.Exists(pathArchivo)) //comprobamos si el archivo existe o no
            {
                Console.WriteLine("El archivo no existe");
                return incidencias;// Debolbemos el archivo para estar seguros
            }
            try
            {
                string linea;// Declaramos la variable linea
                using (StreamReader sr = new StreamReader(pathArchivo))//usamos esto para leer el archivo
                    while ((linea = sr.ReadLine()) != null)//decimos que queremos leer linea a linea mientras no esten en blanco
                    {
                        if (string.IsNullOrWhiteSpace(linea))//leemos
                        {
                            string[] campos = linea.Split(';');//decimos que vamos a separar los campos por ;
                            incidencias.Add(campos);//añadimos a los campos
                        }
                    }
            }
            catch (Exception error)//si el archivo tiene un espacio vacio mostramos esto
            {
                Console.WriteLine($"Error al leer el archivo {error.Message}");
            }
             return incidencias;//y nuevamente devolvemos el archivo para asegurarnos
        }

        static void generarReporte(List<string[]> incidencias)//esto es para generar el reporte
        {
            if (incidencias.Count == 0) // == para comparar
            {
                Console.WriteLine("No hay incidencias para reportar.");//mostramos esto si es que las incidencias son 0
                return;
            }
            Dictionary<string, int> conteoPorprioridad = new Dictionary<string, int>();//usamos la variable diccionario para crear las prioridades y listarlas

            foreach (string[] inc in incidencias)//para cada incidencia en incidencias
            {
                if (inc.Length < 4) continue;//si hay menos de 4 incidencias entonces sigue
                string prioridad = inc[3]; //elegimos el tercer campo
                if (conteoPorprioridad.ContainsKey(prioridad))//cuenta las prioridades en el campo prioridad
                { 
                conteoPorprioridad[prioridad]++;//les suma +1 

                }
                else
                    conteoPorprioridad[prioridad]= 1;//1 porque minimo hay un registro
            }
            Console.WriteLine("\n REPORTE DE INCIDENCIAS");
            Console.WriteLine($"Total Atentidad: {incidencias.Count}");
            Console.WriteLine("Detalle por Prioridad");
            foreach (var inc in conteoPorprioridad)//por cada variable de conteo en incidencias hacer lo de abajo
            {
                Console.WriteLine($"\nPrioridad {inc.Key}: {inc.Value}");
            }

        }






        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
            new string[] {"1","Diego Vargas","No imprime","Alta" },
            new string[] {"2","Carlos Martinex","Olvido la contraseña","Baja" },
            new string[] {"3","Ana Guete","Wifi lento","Alta" },
            new string[] {"4","Juan Diaz","Pantalla Azul","Media" },
            new string[] {"5","Maria Gomez","Pc no enciende","Alta" },


            };
            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");
            GuardarIncidencias(incidenciasToday);
            Console.WriteLine("\n-----Leyendo incidencias del archivo ----");
            List<string[]> incidenciasleidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEÍDAS: ");
            Console.WriteLine($"{"ID",-4}){ "Usuario", -15} { "Descripcion", -20} {"prioridad", -10}");
            Console.WriteLine(new string('-',55));

            foreach (string[] inc in incidenciasleidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15} {inc[2],-20}{inc[3],-10}");
            
            }
            generarReporte(incidenciasToday);
            Console.WriteLine("\nPresione cualquier tecla para salir!!!!");
            Console.ReadKey();
            

        }
    }
}
