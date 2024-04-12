using Resources;

Node<int> node = new(5, null);

node.Append(2);
node.Append(1);
node.Append(4);
node.Append(3);
node.Append(4);
node.Append(6);
Console.WriteLine(node);

System.Console.WriteLine("----------------------");

System.Console.WriteLine($"2 value");
System.Console.WriteLine(node.LeftChildren);
System.Console.WriteLine("----------------------");
System.Console.WriteLine(node.LeftChildren?.RightChildren);