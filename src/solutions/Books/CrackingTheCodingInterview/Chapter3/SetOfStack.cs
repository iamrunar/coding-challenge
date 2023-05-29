namespace solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p3;

public class SetOfStack
{
    private int _maxStackSize;

    public SetOfStack(int maxStackSize)
    {
        this._maxStackSize = maxStackSize;
    }

    public List<Stack<int>> Stacks { get;} = new ();
    public Stack<int> LastStack => Stacks[Stacks.Count-1];

    public int Pop()
    {
        var value = LastStack.Pop();
        if (Stacks.Count >= 2 && LastStack.Count == 0)
        {
            Stacks.RemoveAt(Stacks.Count-1);
        }
        return value;
    }

    public int PopAt(int index)
    {
        var stackAtIndex = Stacks[index];
        var value = stackAtIndex.Pop();

        if (index>=1)
        {
            if (stackAtIndex.Count==0)
            {
                Stacks.RemoveAt(index);
            }
        }
        return value;
    }

    public void Push(int v)
    {
        if (Stacks.Count == 0 || LastStack.Count == _maxStackSize)
        {
            Stacks.Add(new Stack<int>(_maxStackSize));
        }
        LastStack.Push(v);
    }
}