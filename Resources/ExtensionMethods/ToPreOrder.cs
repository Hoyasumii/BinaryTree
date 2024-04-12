namespace Resources.ExtensionMethods;

using Resources;
using Types;

public static class EMToPreOrder {
  public static T[] ToPreOrder<T>(this Node<T> node) where T : IComparable<T> {
    if (node.Grade == 0) return [node.Value];
    Resources.Stack<Node<T>> stack = null!;
    
    if (node.RightChildren != null) {
      stack.Push(node.RightChildren);
    }

    // T[] preOrderedArray = new T[];
    // Node<T> current = node;


    // while (node.LeftChildren != null) {

    // }

    // System.Console.WriteLine(EMToPreOrder.FindLeftLeaf<T>(node).Value);
    return [node.Value];
  }

  // public static INode<T> FindLeftLeaf<T>(INode<T> node) where T: IComparable<T> {
  //   if (node.LeftChildren == null) {
  //     return node;
  //   }
  //   return FindLeftLeaf(node.LeftChildren);
  // }

  // public static INode<T> GetRoot<T>(INode<T> node) where T: IComparable<T> {
  //   return node.Root;
  // }

  // public static INode<T> FindRightLeaf<T>(INode<T> node) where T: IComparable<T> {

  // }

}