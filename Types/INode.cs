namespace Types;

public interface INode<T> {
  INode<T>? Root { get; }
  INode<T>? LeftChildren { get; }
  INode<T>? RightChildren { get; }
  T Value { get; }
  int Grade { get; }

  void Append(T value);

}