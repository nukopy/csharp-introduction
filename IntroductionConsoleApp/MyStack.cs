public interface IStack<T>
{
    public void Push(T data);
    public T Pop();
}


public class MyStack<T> : IStack<T>
{
    private Entry _top;

    public void Push(T data)
    {
        _top = new Entry(_top, data);
    }

    public T Pop()
    {
        if (_top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T result = _top.Data;
        _top = _top.Next;

        return result;
    }

    private class Entry
    {
        public Entry Next { get; set; }
        public T Data { get; set; }

        public Entry(Entry next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
