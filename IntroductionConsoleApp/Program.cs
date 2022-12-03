// impl: https://learn.microsoft.com/ja-jp/dotnet/csharp/tour-of-csharp/#program-structure

class ExampleClass
{
    public static void Main()
    {
        MyStack<int> s = new MyStack<int>();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
    }
}
