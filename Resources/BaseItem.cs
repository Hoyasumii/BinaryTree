namespace Resources;

using Types;

public class BaseItem<T>(T currentValue) : IBaseItem<T, BaseItem<T>> where T : IComparable<T>
{
    public T CurrentValue { get; } = currentValue;

    public BaseItem<T>? Next { get; set; } = null;
}