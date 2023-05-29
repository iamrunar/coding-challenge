namespace solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p2;

public interface IStackWithMin
{
    int? Min();
    int Pop();
    void Push(int value);
}

public class StackWithMinContext : IStackWithMin
{
    private readonly Stack<StackContext> _stack = new();

    public int? Min()
    {
        return GetLastMinOrNull();
    }

    public int Pop()
    {
        return _stack.Pop().Value; //or _stack.Pop witll throw the InvalidOperationException
    }

    public void Push(int value)
    {
        var min = value;

        var lastMin = GetLastMinOrNull();
        if (lastMin.HasValue)
        {
            min = Math.Min(lastMin.Value, value);
        }

        _stack.Push(new StackContext(value, min));

    }
    //local functions
    private int? GetLastMinOrNull()
    {
        if (_stack.Count == 0) return null;

        return _stack.Peek().Min;
    }

    private class StackContext
    {
        public StackContext(int value, int min)
        {
            Value = value;
            Min = min;
        }

        public int Value { get; }

        public int Min { get; }
    }
}

public class StackWithMinStack : IStackWithMin
{
    private Stack<int> _values = new();
    private Stack<int> _minValues = new();

    public int? Min()
    {
        return _minValues.Count > 0 
            ? _minValues.Peek()
            : null;
    }

    public int Pop()
    {
        var value = _values.Pop();
        if (_minValues.Peek() == value) _minValues.Pop();

        return value;
    }

    public void Push(int value)
    {
        _values.Push(value);
        AddToMinsIfLess(value);

        void AddToMinsIfLess(int v)
        {
            if (_minValues.Count > 0 && v >= _minValues.Peek())
            {
                return;
            }

            _minValues.Push(v);
        }
    }
}