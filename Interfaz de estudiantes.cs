using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void imprimirCabecera(string nombreMateria, int group, string N, string A)
        {
            //Ordenamos los datos del modulo
            Console.WriteLine("=======================================================");
            Console.WriteLine(" Universidad del caribe");
            Console.WriteLine($" Asignatura:{nombreMateria}");
            Console.WriteLine($"Nombre: {N} ");
            Console.WriteLine($"Apellido: {A} ");
            Console.WriteLine($"Grupo: {group}");
            Console.WriteLine("========================================================");

        }
        static void main(string[] args)
            //Le damos los datos al modulo para que los organice según la función
        {
            imprimirCabecera("Fundamentos de programacion", 1, "Diego", "vargas");
        
        
        }


        public MainWindow()
        {

            InitializeComponent();
        }
    }
}
