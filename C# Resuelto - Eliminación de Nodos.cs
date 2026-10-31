public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);

        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);

        else
        {
            // Caso 1 y 2: Un solo hijo o sin hijos
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

            // Caso 3: Dos hijos
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}
