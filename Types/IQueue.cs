namespace Types;

public interface IQueue<T, BI> where T : IComparable<T> where BI : IBaseItem<T, BI> {
  BI CurrentValue { get; }
  T Front { get; }
  int Size { get; }
  void Enqueue(T newItem, BI currentValue);
  T Dequeue();
}