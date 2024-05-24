using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarrior.Collections
{
  public sealed class BinarySearchTree<K>
  {
    private readonly IComparer<K> KeyComparer;
    private Node Root;

    public BinarySearchTree(IComparer<K> keyComparer)
    {
      KeyComparer = keyComparer;
    }

    /* Insertion */

    /// <param name="key">A non-null key to insert.  Re-insertion of an existing key is ignored.</param>
    /// <returns>this</returns>
    public BinarySearchTree<K> Add(K key)
    {
      Node child = new Node(key);
      if (Root == null)
      {
        Root = child;
        return this;
      }

      Node parent = FindParentOrDuplicate(child);
      int order = KeyComparer.Compare(child.Key, parent.Key);
      if (order == 0)
        return this;

      if (order < 0)
        parent.Left = child;
      else
        parent.Right = child;

      return this;
    }

    private Node FindParentOrDuplicate(Node child)
    {
      Node ancestor = Root;
      while (true)
      {
        int order = KeyComparer.Compare(child.Key, ancestor.Key);
        if (order < 0 && ancestor.Left != null)
        {
          ancestor = ancestor.Left;
          continue;
        }
        else if (order > 0 && ancestor.Right != null)
        {
          ancestor = ancestor.Right;
          continue;
        }

        return ancestor;
      }
    }

    /* Traversal */

    /// <returns>All keys in the tree, in ascending order</returns>
    public IList<K> GetKeys()
    {
      IList<Node> visited = new List<Node>();
      Stack<Node> visitRightSubtree = new Stack<Node>();
      for (Node current = Root; current != null; current = current.Left)
        visitRightSubtree.Push(current);

      while (visitRightSubtree.Count > 0)
      {
        Node current = visitRightSubtree.Pop();
        visited.Add(current);
        for (Node rightSubtreeRoot = current.Right; rightSubtreeRoot != null; rightSubtreeRoot = rightSubtreeRoot.Left)
          visitRightSubtree.Push(rightSubtreeRoot);
      }

      return visited.Select(x => x.Key).ToList();
    }

    /* Data */

    private sealed class Node
    {
      public readonly K Key;
      public Node Left;
      public Node Right;

      public Node(K key)
      {
        Key = key;
        Left = null;
        Right = null;
      }
    }
  }
}
