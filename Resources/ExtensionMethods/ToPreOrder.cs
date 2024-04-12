namespace Resources.ExtensionMethods;

using Types;

public static class EMToPreOrder {
  public static T[] ToPreOrder<T>(this INode<T> node) where T: IComparable<T> {
    if (node.Grade == 0) return [node.Value];
    // T[] preOrderedArray = new T[];
    INode<T> current = node;


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