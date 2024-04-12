namespace Types;

public interface IStack<T, BI> where T : IComparable<T> where BI : IBaseItem<T, BI> {
  BI CurrentValue { get; }
  T Top { get; }
  int Size { get; }
  void Push(T item);
  T Pop();
}