
using System;
using System.Collections.Generic;

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

public class TreeTraversals
{
    // Raiz del arbol
    public Node Root;

    // Metodo para insertar numeros
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

    // 1. Recorrido Preorden
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Recorrido Posorden
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. Recorrido por niveles BFS
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Clase principal
public class Program
{
    public static void Main(string[] args)
    {
        TreeTraversals arbol = new TreeTraversals();

        // Insertar numeros
        int[] numeros = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int numero in numeros)
        {
            arbol.Insert(numero);
        }

        Console.WriteLine("RECORRIDOS DEL ARBOL BST");
        Console.WriteLine("------------------------");

        Console.Write("Preorden: ");
        arbol.PreOrder(arbol.Root);

        Console.WriteLine();

        Console.Write("Inorden: ");
        arbol.InOrder(arbol.Root);

        Console.WriteLine();

        Console.Write("Posorden: ");
        arbol.PostOrder(arbol.Root);

        Console.WriteLine();

        Console.Write("Por niveles: ");
        arbol.LevelOrder(arbol.Root);

        Console.WriteLine("\n\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}
