using Types;

namespace Resources;

public class Stack<T>(T value) : IStack<T, BaseItem<T>> where T : IComparable<T>
{
    public BaseItem<T> CurrentValue { get; private set; } = new(value);

    public T Top {
      get {
        return CurrentValue.CurrentValue;
      }
    }

    public int Size { get; private set;} = 1;

    public T Pop()
    {
      if (CurrentValue == null) {
        throw new Exception("Não dá pra desenfileirar uma fila sem conteúdo.");
      }

      BaseItem<T> currentValue = CurrentValue;

      if (CurrentValue.Next == null) {
        CurrentValue = null!;
        Size = 0;
        return currentValue.CurrentValue;
      }

      CurrentValue = CurrentValue.Next;
      Size--;

      return currentValue.CurrentValue;
    }

    public void Push(T item)
    {
      BaseItem<T> newItem = new(item);

      if (CurrentValue != null) {
        newItem.Next = CurrentValue;
      }

      CurrentValue = newItem;
      Size++;
    }
} 