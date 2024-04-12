namespace Types;

public interface INode<T, NodeType> where T : IComparable<T> where NodeType : INode<T, NodeType> {
  NodeType? Root { get; }
  NodeType? LeftChildren { get; }
  NodeType? RightChildren { get; }
  T Value { get; }
  int Grade { get; }

  void Append(T value);

}