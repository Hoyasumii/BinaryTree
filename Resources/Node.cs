namespace Resources;

using System.Text;
using Types;

public class Node<T>(T value, Node<T>? root) : INode<T, Node<T>>, IComparable<Node<T>> where T : IComparable<T>
{
  public Node<T>? Root { get; private set; } = root;
  public Node<T>? LeftChildren { get; private set; } = null;
  public Node<T>? RightChildren { get; private set; } = null;
  public T Value { get; private set; } = value;
  public int Grade { get {
    int counter = 0;

    if (LeftChildren != null) counter++;
    if (RightChildren != null) counter++;

    return counter;
  } }

  public void Append(T value) {

    int comparator = value.CompareTo(Value);

    if (comparator < 0) {
      if (LeftChildren == null) {
        LeftChildren = new Node<T>(value, this);
        return;
      }

      LeftChildren.Append(value);
      return;
    }

    if (RightChildren == null) {
      RightChildren = new Node<T>(value, this);
      return;
    }

    RightChildren.Append(value);
  }

    public int CompareTo(Node<T>? other)
    {
      if (other == null) return 1;
      return other.Value.CompareTo(Value);
    }

    public override string ToString() {

    StringBuilder returnText = new();

    returnText.AppendLine($"About: Grade {Grade} Node<{typeof(T)}>");
    returnText.AppendLine($"Value: {Value}");

    if (Root != null) returnText.AppendLine($"Root: {Root.Value}");

    if (LeftChildren != null) returnText.AppendLine($"Left: {LeftChildren.Value}");

    if (RightChildren != null) returnText.AppendLine($"Right: {RightChildren.Value}");
    
    return returnText.ToString();
  }

}