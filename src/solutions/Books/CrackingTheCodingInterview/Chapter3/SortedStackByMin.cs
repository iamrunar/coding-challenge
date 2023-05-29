namespace solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p5;

public class SortedStackByMin
{
    private Stack<int> _stack =new ();

    public bool IsEmpty()
    {
        return _stack.Count==0;
    }

    public int Peek()
    {
        return _stack.Peek();
    }

    public int Pop()
    {
        return _stack.Pop();
    }

    public void Push(int v)
    {
        Stack<int> s2 = new ();
        PushBefore(_stack, s2, v);
        _stack.Push(v);
        PushFrom(s2, _stack);

        void PushBefore(Stack<int> from, Stack<int> to, int val)
        {
            while (from.Count>0 && from.Peek() < val)
                to.Push(from.Pop());
        }

        void PushFrom(Stack<int> from, Stack<int> to)
        {
            while (from.Count>0)
                to.Push(from.Pop());
        }
    }
}