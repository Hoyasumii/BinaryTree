namespace Resources.ExtensionMethods;

using System.Text;

public static class EMShowArray {
  public static string ShowArray<T>(this T[] target) where T: IComparable<T> {
    StringBuilder returnText = new();

    returnText.Append($"[{string.Join(", ", target)}]");

    return returnText.ToString();
  }
}