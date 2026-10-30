using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public Node(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
    }
    public class BinarySearchTree
    {
        public Node Root;
        // Inserción Recursiva Preservando Propiedad BST
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }
        private Node InsertRec(Node root, int data)
        {
            if (root == null)
                return new Node(data);
            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);
            return root;
        }
        // Búsqueda de un Elemento O(log N)
        public bool Search(Node root, int key)
        {
            if (root == null) return false;
            if (root.Data == key) return true;
            return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
        }
}

        static void Main(string[] args)
        {
            BinarySearchTree arbol = new BinarySearchTree();

            // Insertar elementos
            arbol.Insert(15);
            arbol.Insert(69);
            arbol.Insert(67);
            arbol.Insert(220);
            arbol.Insert(405);
            arbol.Insert(40);
            arbol.Insert(35);

            Console.WriteLine("ARBOL BINARIO DE BUSQUEDA");
            Console.WriteLine("-------------------------");

            // Buscar un elemento
            int numero = 35;

            if (arbol.Search(arbol.Root, numero))
            {
                Console.WriteLine("El numero " + numero + " SI existe en el arbol.");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " NO existe en el arbol.");
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();





        }
    }
}
