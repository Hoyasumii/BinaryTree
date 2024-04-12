namespace Types;

public interface IBaseItem<T, ChildrenT> {
  T CurrentValue { get; }
  ChildrenT? Next { get; }
}