using Types;

namespace Resources;

public class Queue<T>(T value) : IQueue<T, BaseItem<T>> where T : IComparable<T>
{
    public BaseItem<T> CurrentValue { get;  set; } = new(value);

    public T Front {
      get {
        if (CurrentValue == null) {
          throw new Exception("A fila não tem conteúdo");
        }
        return CurrentValue.CurrentValue;
      }
    }

    public int Size { get; private set; } = 1;

    public T Dequeue()
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

    public void Enqueue(T newItem, BaseItem<T>? currentValue = null)
    {
      if (CurrentValue == null) {
        CurrentValue = new(newItem);
        Size++;
        return;
      }
      if (CurrentValue.Next != null) {
        Enqueue(newItem, CurrentValue.Next);
        return;
      }
      CurrentValue.Next = new(newItem);
      Size++;
    }
}