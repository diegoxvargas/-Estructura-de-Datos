using System;

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

    // Inserción
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

    // Búsqueda
    public bool Search(Node root, int key)
    {
        if (root == null) return false;

        if (root.Data == key) return true;

        return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
    }

    // RECORRIDO PREORDEN
    public void Preorden(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            Preorden(root.Left);
            Preorden(root.Right);
        }
    }

    // RECORRIDO INORDEN
    public void Inorden(Node root)
    {
        if (root != null)
        {
            Inorden(root.Left);
            Console.Write(root.Data + " ");
            Inorden(root.Right);
        }
    }

    // RECORRIDO POSORDEN
    public void Posorden(Node root)
    {
        if (root != null)
        {
            Posorden(root.Left);
            Posorden(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar valores del árbol
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        Console.WriteLine("Recorrido Preorden:");
        bst.Preorden(bst.Root);

        Console.WriteLine("\nRecorrido Inorden:");
        bst.Inorden(bst.Root);

        Console.WriteLine("\nRecorrido Posorden:");
        bst.Posorden(bst.Root);
    }
}
